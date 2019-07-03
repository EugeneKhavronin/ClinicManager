using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicManager.Domain.Services
{
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
            return await _context.Clinics.FirstOrDefaultAsync();
        }

        /// <inheritdoc/>
        public async Task<Guid> CreateClinic(Clinic clinic)
        {
            _context.Clinics.Add(clinic);
            await _context.SaveChangesAsync();
            return clinic.ClinicGuid;
        }

        /// <inheritdoc/>
        public async Task<Guid> UpdateClinic(Clinic clinic)
        {
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