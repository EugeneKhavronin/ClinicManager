using System;
using Microsoft.AspNetCore.Http;
namespace ClinicManager.Domain.Models
{
    /// <summary>
    /// Модель добавления фотографии
    /// </summary>
    public class AddPictureModel
    {
        public Guid PicGuid { get; set; }
        public string Title { get; set; }
        public IFormFile Picture { get; set; }
        
        //public string PictureType { get; set; }
    }
}