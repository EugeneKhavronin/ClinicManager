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
        public Guid PictureGuid { get; set; }
        
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
        public Clinic ClinicPic { get; set; }

    }
}