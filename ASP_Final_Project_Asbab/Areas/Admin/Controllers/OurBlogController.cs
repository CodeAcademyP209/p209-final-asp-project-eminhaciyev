using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using ASP_Final_Project_Asbab.FileExtensions;
using ASP_Final_Project_Asbab.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static ASP_Final_Project_Asbab.Utilities.Utilities;

namespace ASP_Final_Project_Asbab.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurBlogController : Controller
    {
        private readonly AsbabDbContext _context;
        private readonly IHostingEnvironment _env;

        public OurBlogController(AsbabDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _context.OurBlogs.ToListAsync();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            OurBlog model = new OurBlog();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(include: "Title, Description, Date, Photo")] OurBlog ourBlog)
        {
            if (!ModelState.IsValid)
            {
                return View(ourBlog);
            }

            if (ourBlog.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can't be null...");
                return View(ourBlog);
            }

            if (!ourBlog.Photo.isImage())
            {
                ModelState.AddModelError("Photo", "Photo type is not valid...");
                return View(ourBlog);
            }

            ourBlog.Image = await ourBlog.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");
            ourBlog.Date = DateTime.Now.ToString("MMMM dd,  yyyy");
            _context.OurBlogs.Add(ourBlog);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var ourBlog = _context.OurBlogs.Find(id);

            if (ourBlog == null)
            {
                return NotFound();
            }

            return View(ourBlog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(include: "Title, Description, Date, Photo")] OurBlog ourBlog)
        {
            if (!ModelState.IsValid)
            {
                return View(ourBlog);
            }

            var ourBlogBefore = _context.OurBlogs.Find(id);

            if (ourBlog.Photo != null)
            {
                if (!ourBlog.Photo.isImage())
                {
                    ModelState.AddModelError("Photo", "Photo type is not valid...");
                    return View(ourBlog);
                }
                //Utilities.Remove before image
                RemoveFile(_env.WebRootPath, "images", ourBlogBefore.Image);
                //Add new Image
                ourBlogBefore.Image = await ourBlog.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");
            }

            ourBlogBefore.Title = ourBlog.Title;
            ourBlogBefore.Description = ourBlog.Description;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var ourBlog = _context.OurBlogs.Find(id);

            if (ourBlog == null)
            {
                return NotFound();
            }
            return View(ourBlog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {

            var ourBlog = _context.OurBlogs.Find(id);
            RemoveFile(_env.WebRootPath, "images", ourBlog.Image);
            _context.OurBlogs.Remove(ourBlog);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}