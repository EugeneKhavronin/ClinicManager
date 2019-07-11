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
    public class ClinicService : IClinicsService
    {
        private readonly DatabaseContext _context;

        /// <summary/>
        public ClinicService(DatabaseContext context)
        {
            _context = context;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<ClinicViewModel>> GetAll()
        {
            var result = await _context.Clinics.ToListAsync();
            List<ClinicViewModel> results = new List<ClinicViewModel>();
            foreach (var clinic in result)
            {
                var clinicModel = new ClinicViewModel
                {
                    Guid = clinic.Guid,
                    Title = clinic.Title,
                    Address = clinic.Address,
                    PhoneNumber = clinic.PhoneNumber,
                    Url = clinic.Url,
                    Email = clinic.Email,
                    Specialisation = clinic.Specialisation,
                    PictureGuid = clinic.PictureGuid
                };
                results.Add(clinicModel);
            }

            return results;
        }

        /// <inheritdoc/>
        public async Task<ClinicViewModel> Get(Guid guid)
        {
            var clinic = await _context.Clinics.FindAsync(guid);
            ClinicViewModel clinicViewModel = new ClinicViewModel
            {
                Guid = clinic.Guid, Title = clinic.Title,
                Address = clinic.Address, PhoneNumber = clinic.PhoneNumber,
                Url = clinic.Url, Email = clinic.Email, Specialisation = clinic.Specialisation
            };
            return clinicViewModel;
        }

        /// <inheritdoc/>
        public async Task<Guid> Create(ClinicModel clinicModel)
        {
            Clinic clinic = new Clinic(
                clinicModel.Title,
                clinicModel.Address,
                clinicModel.PhoneNumber,
                clinicModel.Url,
                clinicModel.Email,
                clinicModel.Specialisation,
                clinicModel.PictureGuid);

            _context.Clinics.Add(clinic);
            await _context.SaveChangesAsync();
            return clinic.Guid;
        }

        /// <inheritdoc/>
        public async Task<Guid> Update(Guid guid, ClinicModel clinicModel)
        {
            var clinic = await _context.Clinics.FindAsync(guid);

            clinic.Title = clinicModel.Title;
            clinic.Address = clinicModel.Address;
            clinic.PhoneNumber = clinicModel.PhoneNumber;
            clinic.Url = clinicModel.Url;
            clinic.Email = clinicModel.Email;
            clinic.Specialisation = clinicModel.Specialisation;
            clinic.PictureGuid = clinicModel.PictureGuid;

            _context.Clinics.Update(clinic);
            await _context.SaveChangesAsync();
            return clinic.Guid;
        }

        /// <inheritdoc/>
        public async Task Delete(Guid guid)
        {
            var clinic = await _context.Clinics.FindAsync(guid);
            _context.Clinics.Remove(clinic);
            await _context.SaveChangesAsync();
        }
    }
}