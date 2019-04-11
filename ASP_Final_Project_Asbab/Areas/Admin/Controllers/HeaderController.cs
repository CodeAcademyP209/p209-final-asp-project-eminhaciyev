using System;
using System.Collections.Generic;
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
    public class HeaderController : Controller
    {
        private readonly AsbabDbContext _context;
        private readonly IHostingEnvironment _env;


        public HeaderController(AsbabDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public async Task<IActionResult> Index()
        {
            var model = await _context.Headers.ToListAsync();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Header model = new Header();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(include: "Title, Body, Photo")] Header header)
        {
            if (!ModelState.IsValid)
            {
                return View(header);
            }

            if (header.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can't be null...");
                return View(header);
            }

            if (!header.Photo.isImage())
            {
                ModelState.AddModelError("Photo", "Photo type is not valid...");
                return View(header);
            }

            header.Image = await header.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");

            _context.Headers.Add(header);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var head = _context.Headers.Find(id);

            if (head == null)
            {
                return NotFound();
            }

            return View(head);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(include: "Title, Body, Photo")] Header header)
        {
            if (!ModelState.IsValid)
            {
                return View(header);
            }

            var headerBefore = _context.Headers.Find(id);

            if (header.Photo != null)
            {
                if (!header.Photo.isImage())
                {
                    ModelState.AddModelError("Photo", "Photo type is not valid...");
                    return View(header);
                }
                //Utilities.Remove before image
                RemoveFile(_env.WebRootPath, "images", headerBefore.Image);
                //Add new Image
                headerBefore.Image = await header.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");
            }

            headerBefore.Title = header.Title;
            headerBefore.Body = header.Body;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var header = _context.Headers.Find(id);

            if (header == null)
            {
                return NotFound();
            }
            return View(header);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {

            var header = _context.Headers.Find(id);
            RemoveFile(_env.WebRootPath, "images", header.Image);
            _context.Headers.Remove(header);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }



    }
}