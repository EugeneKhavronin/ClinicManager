using System;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using System.IO;
using ClinicManager.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace ClinicManager.Domain.Interfaces
{
    public interface IPictureService
    {
        /// <summary>
        /// Модель изображения
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        Task<Guid> AddPicture(AddPicture pic);
    }
}