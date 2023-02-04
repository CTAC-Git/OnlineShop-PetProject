using Microsoft.AspNetCore.Http;
using System;

namespace OnlineShopWebApp.Models
{
    public class UserPhotoUploader
    {
        public string Name { get; set; }
        public IFormFile UploadedImage { get; set; }
    }
}
