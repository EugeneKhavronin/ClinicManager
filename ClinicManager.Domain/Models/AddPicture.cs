using System;
using Microsoft.AspNetCore.Http;
namespace ClinicManager.Domain.Models
{
    public class AddPicture
    {
        public string Title { get; set; }
        public IFormFile Picture { get; set; }
    }
}