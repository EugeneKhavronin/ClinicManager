using System;

namespace ClinicManager.Domain.Models.Clinic
{
    public class ClinicViewModel : ClinicModel
    {
        /// <summary>
        /// Уникальный идентификатор клиники
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public ClinicViewModel()
        {
        }

        /// <summary>
        /// Конструктор добавление клиники
        /// </summary>
        /// <param name="title">Название клиники</param>
        /// <param name="address">Адрес клиники</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="url">Сайт клиники</param>
        /// <param name="email">Электронная почта клиники</param>
        /// <param name="specialisation">Специализация клиники</param>
        /// <param name="guid">Уникальный идентификатор изображения</param>
        public ClinicViewModel(string title, string address, string phoneNumber, string url, string email,
            string specialisation, Guid guid)
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

        /// <summary>
        /// Конструктор редактирования клиники
        /// </summary>
        /// <param name="guid">Уникальный идентификатор клиники</param>
        /// <param name="title">Название клиники</param>
        /// <param name="address">Адрес клиники</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="url">Сайт клиники</param>
        /// <param name="email">Электронная почта клиники</param>
        /// <param name="specialisation">Специализация клиники</param>
        /// <param name="guid">Уникальный идентификатор изображения</param>
        public ClinicViewModel(Guid guid, string title, string address, string phoneNumber, string url, string email,
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