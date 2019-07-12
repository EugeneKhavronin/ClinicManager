using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ClinicManager.Domain.Models.Picture
{
    /// <summary>
    /// Модель добавления фотографии
    /// </summary>
    public class PictureModel // !!! разделение на модельки
    {
        /// <summary>
        /// Название фотографии
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Интерфейс получения фотографии
        /// </summary>
        [Required]
        public IFormFile Picture { get; set; }
    }
}