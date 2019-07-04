using System;
using Microsoft.AspNetCore.Http;
namespace ClinicManager.Domain.Models
{
    /// <summary>
    /// Модель добавления фотографии
    /// </summary>
    public class PictureModel
    {
        /// <summary>
        /// Название фотографии
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Интерфейс получения фотографии
        /// </summary>
        public IFormFile Picture { get; set; }
    }
}