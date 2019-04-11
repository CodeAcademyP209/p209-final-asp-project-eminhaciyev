using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.Utilities
{
    public static class Utilities
    {
        public static void RemoveFile(string root, string mainFolder, string file)
        {
            string fullPath = Path.Combine(root, mainFolder, file);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }
    }
}
