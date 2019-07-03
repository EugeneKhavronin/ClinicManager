using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using ClinicManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace ClinicManager.Domain.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class PictureService : IPictureService
    {
        private readonly DatabaseContext _context;

        public PictureService(DatabaseContext context)
        {
            _context = context;
        }
        /// <inheritdoc />
        public async Task AddPicture(AddPictureModel pic)
        {
            var picture = new Picture()
            {
                PictureGuid = pic.PicGuid,
                Title = pic.Title,
                //PictureType = pic.PictureType
            };
            using (var memoryStream = new MemoryStream())
            {
                await pic.Picture.CopyToAsync(memoryStream);
                picture.ClinicPicture = memoryStream.ToArray();
                _context.Add(picture);
                await _context.SaveChangesAsync();
            }
        }
        /// <inheritdoc />
        public async Task EditPiсture(Guid picGuid,EditPictureModel editPictureModel)
        {
            Picture newPicture = _context.Pictures.Find(picGuid);
            using (var memoryStream = new MemoryStream())
            {
                await editPictureModel.Picture.CopyToAsync(memoryStream);
                newPicture.ClinicPicture = memoryStream.ToArray();
            }
            newPicture.Title = editPictureModel.Title;
            newPicture.PictureGuid = picGuid;
            _context.Pictures.Update(newPicture);
            _context.SaveChanges();
        }
        /// <inheritdoc />
        public async Task DeletePicture(Guid pictureGuid)
        {
            var picture = await _context.Pictures.FindAsync(pictureGuid);
            _context.Pictures.Remove(picture);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Picture>> GetPictures()
        {
            return await _context.Pictures.ToListAsync();
        }

        public async Task<Picture> GetPicture(Guid picGuid)
        {
            var picture = await _context.Pictures.FindAsync(picGuid);
            return picture;
        }
    }
}