using ClinicManager.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicManager.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        
    }
}