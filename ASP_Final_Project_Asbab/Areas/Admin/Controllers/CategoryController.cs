using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using ASP_Final_Project_Asbab.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Final_Project_Asbab.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AsbabDbContext _context;
        private readonly IHostingEnvironment _env;

        public CategoryController(AsbabDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var model = _context.Categories.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Category model = new Category();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(include: "Name")] Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(include: "Name")] Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            var categoryBefore = _context.Categories.Find(id);
            categoryBefore.Name = category.Name;           

            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Category");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var category = _context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            var category = _context.Categories.Find(id);

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index","Category");
        }
    }
}