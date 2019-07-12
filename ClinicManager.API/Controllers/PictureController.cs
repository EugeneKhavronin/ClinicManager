using System;
using System.Threading.Tasks;
using ClinicManager.Domain.Interfaces;
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
        /// Вывод фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор</param>
        /// <returns></returns>
        [Route("{pictureGuid}")]
        [HttpGet]
        public async Task<FileStreamResult> Get(Guid pictureGuid)
        {
            var picture = await _pictureService.Get(pictureGuid);
            return File(picture.Content, "application/octet-stream", picture.Guid.ToString());
        }

        /// <summary>
        /// Добавление фотографии
        /// </summary>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create(PictureModel pictureModel)
        {
            return await _pictureService.Create(pictureModel);
        }

        /// <summary>
        /// Изменение фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор</param>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        [HttpPut("{pictureGuid}")]
        public async Task<Guid> Update([FromRoute] Guid pictureGuid, PictureModel pictureModel)
        {
            return await _pictureService.Update(pictureGuid, pictureModel);
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