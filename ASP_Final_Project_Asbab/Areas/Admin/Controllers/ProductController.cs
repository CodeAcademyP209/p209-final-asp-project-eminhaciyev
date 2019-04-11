using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using ASP_Final_Project_Asbab.FileExtensions;
using ASP_Final_Project_Asbab.Models;
using ASP_Final_Project_Asbab.Models.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static ASP_Final_Project_Asbab.Utilities.Utilities;

namespace ASP_Final_Project_Asbab.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly AsbabDbContext _context;
        private readonly IHostingEnvironment _env;


        public ProductController(AsbabDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public async Task<IActionResult> Index()
        {            
            return View(await _context.Products.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewModelClasses viewModel = new ViewModelClasses() {
                Categories = _context.Categories.ToList(),
                Product = new Product()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind(include: "Name, Details, Price, Photo")] Product product, int CategoryId)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            if (product.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can't be null...");
                return View(product);
            }

            if (!product.Photo.isImage())
            {
                ModelState.AddModelError("Photo", "Photo type is not valid...");
                return View(product);
            }
            product.CategoryId = CategoryId;

            product.Image = await product.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {

            if (id == null) return NotFound();

            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }
            ViewModelClasses viewModel = new ViewModelClasses() {
            Categories = _context.Categories.ToList(),
            Product = product
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind(include: "Name, Details, Price,DiscountPrice, Photo")] Product product, int CategoryId)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            var productBefore = _context.Products.Find(id);

            if (product.Photo != null)
            {
                if (!product.Photo.isImage())
                {
                    ModelState.AddModelError("Photo", "Photo type is not valid...");
                    return View(product);
                }
                //Utilities.Remove before image
                RemoveFile(_env.WebRootPath, "images", productBefore.Image);
                //Add new Image
                productBefore.Image = await product.Photo.SaveAsync(_env.WebRootPath, "images", "asbabphotos");
            }

            productBefore.Name = product.Name;
            productBefore.Price = product.Price;
            productBefore.DiscountPrice = product.DiscountPrice;
            productBefore.Details = product.Details;
            productBefore.CategoryId = CategoryId;
           


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            ViewBag.Categories = _context.Categories;

            if (id == null) return NotFound();

            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            var viewModel = new ViewModelClasses()
            {
                Categories = _context.Categories.ToList(),
                Product = product
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            ViewBag.Categories = _context.Categories;

            var product = _context.Products.Find(id);
            RemoveFile(_env.WebRootPath, "images", product.Image);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}