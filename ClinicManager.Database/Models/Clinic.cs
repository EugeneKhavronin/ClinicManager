using System;

namespace ClinicManager.Database.Models
{
    public class Clinic
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public Guid ClinicId { get; set; }
        
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
        public Guid PictureId { get; set; }
    }
}