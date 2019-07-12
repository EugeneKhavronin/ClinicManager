using System;
using System.Linq;
using ClinicManager.Database;
using ClinicManager.Database.Models;
using ClinicManager.Domain.Services;
using ClinicManager.Domain.Models;
using ClinicManager.Domain.Models.Clinic;
using ClinicManager.Domain.Models.Picture;
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
            Domain.Models.Picture.PictureModel modelCreate = new Domain.Models.Picture.PictureModel() {Title = "Title1"};

            var isOk = _pictureTest.AddPicture(modelCreate);
            
            Assert.IsNotNull(isOk);
        }
        
        [Test]
        public void GetModel()
        {
            Database.Models.Picture modelGet = new Database.Models.Picture { Title = "Title2" };
            
            var createdData = _contextTest.Pictures.Add(modelGet);
            _contextTest.SaveChanges();
            var getData = _pictureTest.GetPictures();

            Assert.IsNotEmpty(getData.ToString());
        }

        [Test]
        public void PutModel()
        {
            Database.Models.Picture modelPut = new Database.Models.Picture {Title = "Title3"};
            var createdData = _contextTest.Pictures.Add(modelPut);
            Guid modelGuid = modelPut.PictureGuid;
            var Clinic1 = _pictureTest.GetPicture(modelGuid);
            PictureModel update = new PictureModel {Title = "UpdateClinic"};
            var updatedData = _pictureTest.EditPiсture(modelGuid, update);
            

        }
        
        
    }
}