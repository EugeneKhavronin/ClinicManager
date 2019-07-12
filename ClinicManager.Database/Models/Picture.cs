using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManager.Database.Models
{
    /// <summary>
    /// Модель фотографии
    /// </summary>
    public class Picture
    {
        /// <summary>
        /// Уникальный идентификатор фотографии
        /// </summary>
        [Key]
        public Guid Guid { get; set; }

        /// <summary>
        /// Название фотографии
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Фотография клиники
        /// </summary>
        [Required]
        public byte[] ClinicPicture { get; set; }

        /// <summary>
        /// Связи между таблицами
        /// </summary>
        [ForeignKey("Clinic")]
        public Guid ClinicGuid { get; set; }

        /// <summary>
        /// Связи между таблицами
        /// </summary>
        public Clinic ClinicPic { get; set; }

        /// <summary>
        /// Конструктор модели
        /// </summary>
        public Picture()
        {
        }

        /// <summary>
        /// Конструктор добавления модели изображения
        /// </summary>
        /// <param name="title">Название фотографии</param>
        /// <param name="clinicPicture">Фотография клиники</param>
        public Picture(string title, byte[] clinicPicture)
        {
            Guid = Guid.NewGuid();
            Title = title;
            ClinicPicture = clinicPicture;
        }

        /// <summary>
        /// Конструктор редактирования модели изображения
        /// </summary>
        /// <param name="title"></param>
        /// <param name="clinicPicture"></param>
        /// <inheritdoc />
        public Picture(Guid guid, string title, byte[] clinicPicture)
        {
            Title = title;
            ClinicPicture = clinicPicture;
        }
    }
}