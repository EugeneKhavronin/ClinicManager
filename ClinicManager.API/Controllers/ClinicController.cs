using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models.Clinic;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManager.API.Controllers
{
    /// <summary>
    /// Контроллер для получения информации о клиниках
    /// </summary>
    [Route("/api/clinic")]
    [ApiController]
    public class ClinicController : Controller
    {

        private readonly IClinicService _clinicService;

        /// <summary/>
        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        /// <summary>
        /// Просмотр всех клиник 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Clinic>> GetAll()
        {
            return await _clinicService.GetAll();
        }

        /// <summary>
        /// Информация об интересующей клинике
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <returns></returns>
        [HttpGet("{guid}")]
        public async Task<Clinic> GetClinic(Guid guid)
        {
            return await _clinicService.GetClinic(guid);
        }

        /// <summary>
        /// Добавление новой клиники
        /// </summary>
        /// <param name="clinicModel">Модель клиники</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> CreateClinic(ClinicModel clinicModel)
        {
            return await _clinicService.CreateClinic(clinicModel);
        }

        /// <summary>
        /// Редактирование информации о клинике 
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <param name="clinicModel">Модель клиники</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Guid>  UpdateClinic(Guid guid, ClinicModel clinicModel)
        {
            return await _clinicService.UpdateClinic(guid, clinicModel);
        }

        /// <summary>
        /// Удаление клиники
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeleteClinic(Guid guid)
        {
            await _clinicService.DeleteClinic(guid);
            
        }
    }
}