using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using System.IO;
using ClinicManager.Domain.Models;
using Microsoft.AspNetCore.Http;

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
        /// <param name="pic">Модель фотографии</param>
        /// <returns></returns>
        Task AddPicture(AddPictureModel pic);

        /// <summary>
        /// Изменение фотографии
        /// </summary>
        /// <param name="pic">Модель фотографии</param>
        /// <returns></returns>
        Task EditPiсture(Guid picGuid,EditPictureModel editPictureModel);

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