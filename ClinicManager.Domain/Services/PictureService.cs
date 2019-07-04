using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicManager.Domain.Services
{
    /// <inheritdoc />
    public class PictureService : IPictureService
    {
        private readonly DatabaseContext _context;

        /// <summary/>
        public PictureService(DatabaseContext context)
        {
            _context = context;
        }
        
        /// <inheritdoc />
        public async Task<Guid> AddPicture(PictureModel pictureModel)
        {
            Guid guid = Guid.NewGuid();
            var picture = new Picture()
            {
                Title = pictureModel.Title,
                PictureGuid = guid
            };
            using (var memoryStream = new MemoryStream())
            {
                await pictureModel.Picture.CopyToAsync(memoryStream);
                picture.ClinicPicture = memoryStream.ToArray();
                _context.Add(picture);
                await _context.SaveChangesAsync();
            }
            return picture.PictureGuid;
        }
        
        /// <inheritdoc />
        public async Task<Guid> EditPiсture(Guid picGuid, PictureModel pictureModel)
        {
            Picture newPicture = _context.Pictures.Find(picGuid);
            using (var memoryStream = new MemoryStream())
            {
                await pictureModel.Picture.CopyToAsync(memoryStream);
                newPicture.ClinicPicture = memoryStream.ToArray();
            }
            newPicture.Title = pictureModel.Title;
            newPicture.PictureGuid = picGuid;
            _context.Pictures.Update(newPicture);
            _context.SaveChanges();
            return newPicture.PictureGuid;
        }
        
        /// <inheritdoc />
        public async Task DeletePicture(Guid pictureGuid)
        {
            var picture = await _context.Pictures.FindAsync(pictureGuid);
            _context.Pictures.Remove(picture);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Picture>> GetPictures()
        {
            return await _context.Pictures.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<Picture> GetPicture(Guid picGuid)
        {
            return await _context.Pictures.FirstOrDefaultAsync(a=>a.PictureGuid == picGuid);
        }
    }
}