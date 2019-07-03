using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;

namespace ClinicManager.Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClinicService
    {
        /// <summary>
        /// Получение всех клиник
        /// </summary>
        /// <param name="clinic"></param>
        /// <returns></returns>
        Task<List<Clinic>> GetAll();
        /// <summary>
        /// Получение одной клиники
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        Task<Clinic> GetClinic(Guid guid);
        /// <summary>
        /// Добавление клиники
        /// </summary>
        /// <param name="clinic"></param>
        /// <returns></returns>
        Task<Guid> CreateClinic(Clinic clinic);
        /// <summary>
        /// Изменение клиники
        /// </summary>
        /// <param name="clinic"></param>
        /// <returns></returns>
        Task<Guid> UpdateClinic(Clinic clinic);
        /// <summary>
        /// Удаление клиники
        /// </summary>
        /// <param name="clinic"></param>
        /// <returns></returns>
        Task DeleteClinic(Guid guid);
    }
}