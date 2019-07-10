using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models;
using ClinicManager.Domain.Models.Picture;
using Microsoft.AspNetCore.Mvc;


namespace ClinicManager.API.Controllers
{
    /// <summary>
    /// Контроллер по управлению фотографиями
    /// </summary>
    [Route("api/picture")]
    public class PictureController : Controller
    {
        private readonly IPictureService _pictureService;

        public PictureController(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        /// <summary>
        /// Добавление фотографии
        /// </summary>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create(PictureModel pictureModel)
        {
            return await _pictureService.AddPicture(pictureModel);
        }
        
        /// <summary>
        /// Изменение фотографии
        /// </summary>
        /// <param name="picGuid">Уникальный идентификатор</param>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        [HttpPut("{picGuid}")]
        public async Task<Guid> Edit([FromRoute]Guid picGuid,PictureModel pictureModel)
        {
            return await _pictureService.EditPiсture(picGuid, pictureModel);
        }
        
        /// <summary>
        /// Удаление фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор фотографии</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeletePicture(Guid pictureGuid)
        {
            await _pictureService.DeletePicture(pictureGuid);
        }
        /// <summary>
        /// Вывод фотографий
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Picture>> GetPictures()
        {
            return await _pictureService.GetPictures();
        }
        /// <summary>
        /// Вывод фотографии
        /// </summary>
        /// <param name="picGuid">Уникальный идентификатор</param>
        /// <returns></returns>
        [Route("{picGuid}")]
        [HttpGet]
        public async Task<Picture> GetPicture(Guid picGuid)
        {
            return await _pictureService.GetPicture(picGuid);
        }
    }
}