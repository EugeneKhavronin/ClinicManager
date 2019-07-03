using System;
using System.IO;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models;
using Microsoft.AspNetCore.Mvc

namespace ClinicManager.Domain.Services
{
    public class PictureService : IPictureService
    {
        private readonly DatabaseContext _context;

        public PictureService(DatabaseContext context)
        {
            _context = context;
        }
        
        public async Task<Guid> AddPicture([FromBody]AddPicture pic)
        {
            Guid PicGuid = new Guid();
            byte[] ImageData = null;
            using (var BinaryReader = new BinaryReader(pic.Picture.OpenReadStream()))
            {
                ImageData = BinaryReader.ReadBytes((int) pic.Picture.Length);
            }
            Picture picture = new Picture
            {
                picture.Title = pic.Title,
                picture.PictureId = PicGuid,
                picture.ClinicPicture = ImageData
            };
            
            //_context.Pictures.Add(picture);
           //_context.SaveChanges();
            return PicGuid;
        }
    }
}