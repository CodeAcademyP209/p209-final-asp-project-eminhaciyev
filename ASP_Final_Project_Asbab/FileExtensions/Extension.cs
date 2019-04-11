using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.FileExtensions
{
    public static class Extension
    {
        public static bool isImage(this IFormFile file)
        {
            return file.ContentType == "image/jpeg" ||
                    file.ContentType == "image/jpg" ||
                    file.ContentType == "image/png" ||
                    file.ContentType == "image/gif";
        }

        public async static Task<string> SaveAsync(this IFormFile file, string root, string mainFolder, string subFolder)
        {
            string fileName = Path.Combine(subFolder, Guid.NewGuid().ToString() + Path.GetFileName(file.FileName));

            string fullPath = Path.Combine(root, mainFolder, fileName);

            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;

        }

    }
}
