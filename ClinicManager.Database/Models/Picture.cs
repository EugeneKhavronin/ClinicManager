using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicManager.Database.Models
{
    public class Picture 
    {
        /// <summary>
        /// Уникальный идентификатор фотографии
        /// </summary>
        [Key]
        public Guid PictureId { get; set; }
        /// <summary>
        /// Название фотографии
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Фотография клиники
        /// </summary>
        public byte[] ClinicPicture { get; set; }
        
        //public string PictureType { get; set; }
        
        //[ForeignKey("Clinic")]
        //public Guid ClinicGuid { get; set; }
        //public Clinic ClinicPic { get; set; }
        
    }
}