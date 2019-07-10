using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Models.Clinic;
using Microsoft.EntityFrameworkCore;

namespace ClinicManager.Domain.Services
{
    /// <inheritdoc/>
    public class ClinicService : IClinicService
    {
        private readonly DatabaseContext _context;

        /// <summary/>
        public ClinicService(DatabaseContext context)
        {
            _context = context;
        }
        
        /// <inheritdoc/>
        public async Task<List<Clinic>> GetAll()
        {
            return await _context.Clinics.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<Clinic> GetClinic(Guid guid)
        {
            return await _context.Clinics.FirstOrDefaultAsync(a=>a.ClinicGuid == guid);
        }

        /// <inheritdoc/>
        public async Task<Guid> CreateClinic(ClinicModel clinicModel)
        {
            Clinic clinic = new Clinic
            {
                ClinicGuid = Guid.NewGuid(),
                Title = clinicModel.Title,
                Address = clinicModel.Address,
                PhoneNumber = clinicModel.PhoneNumber,
                Url = clinicModel.Url,
                Email = clinicModel.Email,
                Specialisation = clinicModel.Specialisation,
                PictureGuid = clinicModel.PictureGuid
            };

            _context.Clinics.Add(clinic);
            await _context.SaveChangesAsync();
            return clinic.ClinicGuid;
        }

        /// <inheritdoc/>
        public async Task<Guid> UpdateClinic(Guid guid, ClinicModel clinicModel)
        {
            Clinic clinic = _context.Clinics.Find(guid);
            
            clinic.Title = clinicModel.Title;
            clinic.Address = clinicModel.Address;
            clinic.PhoneNumber = clinicModel.PhoneNumber;
            clinic.Url = clinicModel.Url;
            clinic.Email = clinicModel.Email;
            clinic.Specialisation = clinicModel.Specialisation;
            clinic.PictureGuid = clinicModel.PictureGuid;
            
            _context.Clinics.Update(clinic);
            await _context.SaveChangesAsync();
            return clinic.ClinicGuid;

        }

        /// <inheritdoc/>
        public async Task DeleteClinic(Guid guid)
        {
            var clinic = await _context.Clinics.FirstOrDefaultAsync(a => a.ClinicGuid == guid);
            _context.Clinics.Remove(clinic);
            await _context.SaveChangesAsync();
        }
    }
}