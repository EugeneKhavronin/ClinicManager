using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
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
        /// Информация о всех клиниках
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
        /// <param name="guid">Уникальный идентификатор</param>
        /// <returns></returns>
        [HttpGet("{guid}")]
        public async Task<Clinic> GetClinic(Guid guid)
        {
            return await _clinicService.GetClinic(guid);
        }
        
        /// <summary>
        /// Добавление новой клиники
        /// </summary>
        /// <param name="clinic">Модель клиники</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> CreateClinic(Clinic clinic)
        {
            return await _clinicService.CreateClinic(clinic);
        }
        /// <summary>
        /// Редактирование информации о клинике 
        /// </summary>
        /// <param name="clinic">Модель клиники</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Guid> UpdataClinic(Clinic clinic)
        {
            return await _clinicService.UpdateClinic(clinic);
        }

        /// <summary>
        /// Удаление клиники
        /// </summary>
        /// <param name="guid">Уникальный идентификатор</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task DeleteClinic(Guid guid)
        {
            await _clinicService.DeleteClinic(guid);
            
        }
    }
}