using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_Final_Project_Asbab.Controllers
{
    public class BlogController : Controller
    {
        private readonly AsbabDbContext _context;

        public BlogController(AsbabDbContext context)
        {
            _context = context;                
        }

        public async Task<IActionResult> Blog()
        {
            var model = await _context.OurBlogs.ToListAsync();

            return View(model);
        }

        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}