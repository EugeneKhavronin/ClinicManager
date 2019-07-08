using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Models;
using ClinicManager.Domain.Models.Picture;

namespace ClinicManager.Domain.Interfaces
{
    /// <summary>
    /// Сервис для работы с Фотографиями
    /// </summary>
    public interface IPictureService
    {
        /// <summary>
        /// Добавление фотографии
        /// </summary>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        Task<Guid> AddPicture(PictureModel pictureModel);

        /// <summary>
        /// Изменение фотографии
        /// </summary>
        /// <param name="picGuid">Уникальный идентификатор</param>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        Task<Guid> EditPiсture(Guid picGuid, PictureModel pictureModel);

        /// <summary>
        /// Удаление фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор фотографии</param>
        /// <returns></returns>
        Task DeletePicture(Guid pictureGuid);

        /// <summary>
        /// Получение фотографий
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Picture>> GetPictures();

        /// <summary>
        /// Получение фотографии
        /// </summary>
        /// <param name="picGuid">Уникальный идентификатор</param>
        /// <returns></returns>
        Task<Picture> GetPicture(Guid picGuid);
    }
}