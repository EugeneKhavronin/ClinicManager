using System;
using ClinicManager.Database.Models;
using Microsoft.EntityFrameworkCore;
using ClinicManager.Database.Resources;

namespace ClinicManager.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        ResourcesPicture NewPicture = new ResourcesPicture();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Picture>().HasData(new Picture[]
            {
                new Picture
                {
                    Guid = Guid.Parse("00000000-0000-0000-0000-000000000000"), Title = "DefaultPicture",
                    ClinicPicture = NewPicture.PictureArray
                },
            });
        }
    }
}