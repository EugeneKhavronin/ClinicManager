using System;
using System.Linq;
using ClinicManager.Database;
using ClinicManager.Domain.Services;
using ClinicManager.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace ClinicManager.Tests.ServicesTests
{
    [TestFixture]
    public class PictureServicesTest
    {
        DatabaseContext _contextTest;
        PictureService _pictureTest;

        [SetUp]
        public void Init()
        {
            _contextTest = TestInitializer.Provider.GetService<DatabaseContext>();
            
            _pictureTest = new PictureService(_contextTest);
        }

        [Test]
        public void CreateModel()
        {
            Domain.Models.Picture.PictureModel picture1 = new Domain.Models.Picture.PictureModel() {Title = "Title1"};

            var IsOk = _pictureTest.AddPicture(picture1);
            
            Assert.IsNotNull(IsOk);
        }
    }
}