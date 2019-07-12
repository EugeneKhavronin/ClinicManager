using System;
using ClinicManager.Database;
using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace ClinicManager.Tests
{
    [SetUpFixture]
    public class TestInitializer
    {
        public static IServiceProvider Provider { get; private set; }

        [OneTimeSetUp]
        public void Initializer()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DatabaseContext>(options => options.UseInMemoryDatabase("ClinicDB"));

            services.AddScoped<IPictureService, PictureService>();

            Provider = services.BuildServiceProvider();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Provider.GetService<DatabaseContext>().Database.EnsureDeleted();
        }
    }
}