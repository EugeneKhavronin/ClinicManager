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
        /// Вывод фотографий
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Picture>> GetAll()
        {
            return await _pictureService.GetAll();
        }

        /// <summary>
        /// Вывод фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор</param>
        /// <returns></returns>
        [Route("{pictureGuid}")]
        [HttpGet]
        public async Task<Picture> Get(Guid pictureGuid)
        {
            return await _pictureService.Get(pictureGuid);
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
        /// <param name="pictureGuid">Уникальный идентификатор</param>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        [HttpPut("{picGuid}")]
        public async Task<Guid> Update([FromRoute] Guid pictureGuid, PictureModel pictureModel)
        {
            return await _pictureService.UpdatePiсture(pictureGuid, pictureModel);
        }

        /// <summary>
        /// Удаление фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор фотографии</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task Delete(Guid pictureGuid)
        {
            await _pictureService.Delete(pictureGuid);
        }
    }
}