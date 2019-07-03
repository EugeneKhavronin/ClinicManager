using System;

namespace ClinicManager.Database.Models
{
    public class Picture 
    {
        public Guid PictureId { get; set; }
        public string Title { get; set; }

        public byte[] ClinicPicture { get; set; }
    }
}