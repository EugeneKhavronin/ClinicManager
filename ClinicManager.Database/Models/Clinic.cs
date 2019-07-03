using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicManager.Database.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Clinic
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Key]
        public Guid ClinicGuid { get; set; }
        
        /// <summary>
        /// Название клиники
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Адрес клиники
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Сайт клиники
        /// </summary>
        public string Url { get; set; }
        
        /// <summary>
        /// Электронная почта клиники
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Специализация клиники
        /// </summary>
        public string Specialisation { get; set; }
        
        /// <summary>
        /// Уникальный идентификатор изображения
        /// </summary>
       public Guid PictureGuid { get; set; }
    }
}