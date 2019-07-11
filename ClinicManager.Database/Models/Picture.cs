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
        public string Title { get; set; }

        /// <summary>
        /// Фотография клиники
        /// </summary>
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
        /// Конструктор модели
        /// </summary>
        /// <param name="title">Название фотографии</param>
        /// <param name="clinicPicture">Фотография клиники</param>
        public Picture(string title, byte[] clinicPicture)
        {
            Guid = Guid.NewGuid();
            title = Title;
            clinicPicture = ClinicPicture;
        }
    }
}