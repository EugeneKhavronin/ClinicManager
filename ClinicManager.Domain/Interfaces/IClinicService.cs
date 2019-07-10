using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Models.Clinic;

namespace ClinicManager.Domain.Interfaces
{
    /// <summary>
    /// Сервис по работе с клиниками
    /// </summary>
    public interface IClinicService
    {
        /// <summary>
        /// Получение всех клиник
        /// </summary>
        /// <returns></returns>
        Task<List<Clinic>> GetAll();
        /// <summary>
        /// Получение одной клиники
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <returns></returns>
        Task<Clinic> GetClinic(Guid guid);

        /// <summary>
        /// Добавление клиники
        /// </summary>
        /// <param name="clinicModel">Модель клиники</param>
        /// <returns></returns>
        Task<Guid> CreateClinic(ClinicModel clinicModel);

        /// <summary>
        /// Изменение клиники
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <param name="clinicModel">Модель клиники</param>
        /// <returns></returns>
        Task<Guid> UpdateClinic(Guid guid, ClinicModel clinicModel);

        /// <summary>
        /// Удаление клиники
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <returns></returns>
        Task DeleteClinic(Guid guid);
    }
}