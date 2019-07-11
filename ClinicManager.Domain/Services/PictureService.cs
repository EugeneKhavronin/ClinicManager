using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models;
using ClinicManager.Domain.Models.Picture;
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
        public async Task<PictureViewModel> Get(Guid pictureGuid)
        {
            var picture = await _context.Pictures.FindAsync(pictureGuid);
            PictureViewModel viewModel = new PictureViewModel(picture.Guid, picture.ClinicPicture);

            return viewModel;
        }

        /// <inheritdoc />
        public async Task<Guid> Create(PictureModel pictureModel)
        {
            Guid guid = Guid.NewGuid();
            var picture = new Picture()
            {
                Title = pictureModel.Title,
                Guid = guid
            };
            using (var memoryStream = new MemoryStream())
            {
                await pictureModel.Picture.CopyToAsync(memoryStream);
                picture.ClinicPicture = memoryStream.ToArray();
                _context.Add(picture);
                await _context.SaveChangesAsync();
            }

            return picture.Guid;
        }

        /// <inheritdoc />
        public async Task<Guid> Update(Guid pictureGuid, PictureModel pictureModel)
        {
            var newPicture = _context.Pictures.Find(pictureGuid);
            using (var memoryStream = new MemoryStream())
            {
                await pictureModel.Picture.CopyToAsync(memoryStream);
                newPicture.ClinicPicture = memoryStream.ToArray();
            }

            newPicture.Title = pictureModel.Title;
            newPicture.Guid = pictureGuid;
            _context.Pictures.Update(newPicture);
            _context.SaveChanges();
            return newPicture.Guid;
        }

        /// <inheritdoc />
        public async Task Delete(Guid pictureGuid)
        {
            var picture = await _context.Pictures.FindAsync(pictureGuid);
            _context.Pictures.Remove(picture);
            await _context.SaveChangesAsync();
        }
    }
}