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
        /// Получение фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор</param>
        /// <returns></returns>
        Task<PictureViewModel> Get(Guid pictureGuid);

        /// <summary>
        /// Добавление фотографии
        /// </summary>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        Task<Guid> Create(PictureModel pictureModel); //!!!

        /// <summary>
        /// Изменение фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор</param>
        /// <param name="pictureModel">Модель фотографии</param>
        /// <returns></returns>
        Task<Guid> Update(Guid pictureGuid, PictureModel pictureModel);

        /// <summary>
        /// Удаление фотографии
        /// </summary>
        /// <param name="pictureGuid">Уникальный идентификатор фотографии</param>
        /// <returns></returns>
        Task Delete(Guid pictureGuid);
    }
}