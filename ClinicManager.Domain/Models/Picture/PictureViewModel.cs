using System;
using System.IO;

namespace ClinicManager.Domain.Models.Picture
{
    public class PictureViewModel
    {
        /// <summary>
        /// Уникальный идентификатор фотографии
        /// </summary>
        public Guid Guid { get; set; }

        public Stream Content { get; set; }

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public PictureViewModel()
        {
        }

        /// <summary>
        /// Конструктор добавления модели изображения
        /// </summary>
        /// <param name="title">Название фотографии</param>
        /// <param name="clinicPicture">Фотография клиники</param>
        public PictureViewModel(Guid guid, byte[] clinicPicture)
        {
            Guid = Guid.NewGuid();
            Content = new MemoryStream(clinicPicture);
        }
    }
}