using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using ASP_Final_Project_Asbab.FileExtensions;
using ASP_Final_Project_Asbab.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static ASP_Final_Project_Asbab.FileExtensions.Extension;
using static ASP_Final_Project_Asbab.Utilities.Utilities;

namespace ASP_Final_Project_Asbab.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewArrivalController : Controller
    {
        private readonly AsbabDbContext _context;
        private readonly IHostingEnvironment _env;

        public NewArrivalController(AsbabDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var model = _context.NewArrivals.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            NewArrival model = new NewArrival();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(include: "Name, Price,DiscountPrice, Photo")] NewArrival newArrival)
        {
            if (!ModelState.IsValid)
            {
                return View(newArrival);
            }

            if (newArrival.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can't be null...");
                return View(newArrival);
            }

            if (!newArrival.Photo.isImage())
            {
                ModelState.AddModelError("Photo", "Photo type is not valid...");
                return View(newArrival);
            }

            newArrival.Image = await newArrival.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");

            newArrival.Date = DateTime.Now;

            _context.NewArrivals.Add(newArrival);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index","NewArrival");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var arrival = _context.NewArrivals.Find(id);

            if (arrival == null)
            {
                return NotFound();
            }

            return View(arrival);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(include: "Name, Price,DiscountPrice, Photo")] NewArrival newArrival)
        {
            if (!ModelState.IsValid)
            {
                return View(newArrival);
            }

            var newArrivalBefore = _context.NewArrivals.Find(id);

            if (newArrival.Photo != null)
            {
                if (!newArrival.Photo.isImage())
                {
                    ModelState.AddModelError("Photo", "Photo type is not valid...");
                    return View(newArrival);
                }
                //Utilities.Remove before image
                RemoveFile(_env.WebRootPath, "images", newArrivalBefore.Image);
                //Add new Image
                newArrivalBefore.Image = await newArrival.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");
            }

            newArrivalBefore.Name = newArrival.Name;
            newArrivalBefore.Price = newArrival.Price;
            newArrivalBefore.DiscountPrice = newArrival.DiscountPrice;

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var arrival = _context.NewArrivals.Find(id);

            if (arrival == null)
            {
                return NotFound();
            }
            return View(arrival);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            var arrival = _context.NewArrivals.Find(id);
            RemoveFile(_env.WebRootPath, "images", arrival.Image);
            _context.NewArrivals.Remove(arrival);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}