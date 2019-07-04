using Microsoft.AspNetCore.Http;

namespace ClinicManager.Domain.Models.Picture
{
    /// <summary>
    /// Модель изменения фотографии
    /// </summary>
    public class EditPictureModel
    {
        //public Guid PicGuid { get; set; }
        
        public string Title { get; set; }
        
        public IFormFile Picture { get; set; }
        
    }
}