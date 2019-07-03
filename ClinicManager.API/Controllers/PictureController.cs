using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models;
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
        /// <param name="addPictureModel">Модель добавления фотографии</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create(AddPictureModel addPictureModel)
        {
            await _pictureService.AddPicture(addPictureModel);
            return addPictureModel.PicGuid;    
        }
        
        /// <summary>
        /// Изменение фотографии
        /// </summary>
        /// <param name="picGuid">Уникальный идентификатор фотографии</param>
        /// <param name="editPictureModel">Модель изменения фотографии</param>
        /// <returns></returns>
        [HttpPut("{picGuid}")]
        public async Task<Guid> Edit([FromRoute]Guid picGuid,EditPictureModel editPictureModel)
        {
            await _pictureService.EditPiсture(picGuid, editPictureModel);
            return picGuid;
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

        [HttpGet]
        public async Task<IEnumerable<Picture>> GetPictures()
        {
            return await _pictureService.GetPictures();
        }
        [Route("{picGuid}")]
        [HttpGet]
        public async Task<Picture> GetPicture(Guid picGuid)
        {
            return await _pictureService.GetPicture(picGuid);
        }
    }
}