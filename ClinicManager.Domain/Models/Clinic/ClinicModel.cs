using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicManager.Domain.Models.Clinic
{
    /// <summary>
    /// Класс модели клиники
    /// </summary>
    public class ClinicModel
    {
        /// <summary>
        /// Название клиники
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Адрес клиники
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        [Required]
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
        [Required]
        public string Specialisation { get; set; }

        /// <summary>
        /// Уникальный идентификатор изображения
        /// </summary>
        public Guid PictureGuid { get; set; }
    }
}