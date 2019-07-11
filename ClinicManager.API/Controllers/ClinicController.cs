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
        /// Информация о всех клиниках
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Clinic>> GetAll()
        {
            return await _clinicService.GetAll();
        }

        /// <summary>
        /// Информация об интересующей клинике
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <returns></returns>
        [HttpGet("{guid}")]
        public async Task<Clinic> Get(Guid guid)
        {
            return await _clinicService.Get(guid);
        }

        /// <summary>
        /// Добавление новой клиники
        /// </summary>
        /// <param name="clinicModel">Модель клиники</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<Guid> Create(ClinicModel clinicModel)
        {
            return await _clinicService.Create(clinicModel);
        }

        /// <summary>
        /// Редактирование информации о клинике 
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <param name="clinicModel">Модель клиники</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<Guid> Update(Guid guid, ClinicModel clinicModel)
        {
            return await _clinicService.Update(guid, clinicModel);
        }

        /// <summary>
        /// Удаление клиники
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task Delete(Guid guid)
        {
            await _clinicService.Delete(guid);
        }
    }
}