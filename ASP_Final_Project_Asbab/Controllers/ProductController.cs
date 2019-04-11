using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using ASP_Final_Project_Asbab.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_Final_Project_Asbab.Controllers
{
    public class ProductController : Controller
    {
        private readonly AsbabDbContext _context;

        public ProductController(AsbabDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductGrid()
        {
            return View();
        }

        public async Task<ActionResult> ProductDetails(int? id)
        {
            if (id == null) return NotFound("Bele bir Id tapilmadi");

            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound("Bele bir Id tapilmadi");
            }

            ViewModelClasses viewModel = new ViewModelClasses()
            {
                Categories = await _context.Categories.ToListAsync(),
                Category = new Models.Category(),
                Product = product
            };

            return View(viewModel);
        }

        public async Task<ActionResult> ProductBlogDetails(int? id)
        {
            if (id == null) return NotFound("Bele bir Id tapilmadi");

            var ourBlog = _context.OurBlogs.Find(id);

            if (ourBlog == null)
            {
                return NotFound("Bele bir Id tapilmadi");
            }

            ViewModelClasses viewModel = new ViewModelClasses()
            {
                Categories = await _context.Categories.ToListAsync(),
                OurBlogs = ourBlog
            };

            return View(viewModel);
        }
    }
}