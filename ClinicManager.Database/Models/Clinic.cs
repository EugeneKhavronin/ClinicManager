using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicManager.Database.Models
{
    /// <summary>
    /// Класс клиники
    /// </summary>
    public class Clinic
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        [Key]
        public Guid Guid { get; set; }

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

        /// <summary>
        /// конструктор модели
        /// </summary>
        public Clinic()
        {
        }

        /// <summary>
        /// Конструктор модели
        /// </summary>
        /// <param name="title">Название клиники</param>
        /// <param name="address">Адрес клиники</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="url">Сайт клиники</param>
        /// <param name="email">Электронная почта клиники</param>
        /// <param name="specialisation">Специализация клиники</param>
        /// <param name="guid">Уникальный идентификатор изображения</param>
        public Clinic(string title, string address, string phoneNumber, string url, string email, string specialisation,
            Guid guid)
        {
            Guid = Guid.NewGuid();
            Title = title;
            Address = address;
            PhoneNumber = phoneNumber;
            Url = url;
            Email = email;
            Specialisation = specialisation;
            PictureGuid = guid;
        }

        /// <inheritdoc />
        public Clinic(Guid guid, string title, string address, string phoneNumber, string url, string email,
            string specialisation, Guid pictureGuid)
        {
            Guid = guid;
            Title = title;
            Address = address;
            PhoneNumber = phoneNumber;
            Url = url;
            Email = email;
            Specialisation = specialisation;
            PictureGuid = pictureGuid;
        }
    }
}