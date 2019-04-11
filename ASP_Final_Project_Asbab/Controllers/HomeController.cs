using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_Final_Project_Asbab.Models;
using ASP_Final_Project_Asbab.Data;
using Microsoft.EntityFrameworkCore;
using ASP_Final_Project_Asbab.Models.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace ASP_Final_Project_Asbab.Controllers
{
    public class HomeController : Controller
    {
        private readonly AsbabDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(AsbabDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        public async Task<IActionResult> Index()
        {
            var viewModel = new ViewModelClasses()
            {
                Header = await _context.Headers.ToListAsync(),
                NewArrival = await _context.NewArrivals.OrderByDescending(d => d.Date).ToListAsync(),
                Products = await _context.Products.Where(d => d.Price < 35 && d.Price > 20).ToListAsync(),
                ProductRated = await _context.Products.Take(3).ToListAsync(),
                OurBlog = await _context.OurBlogs.ToListAsync(),
                UserProduct = await _context.UserProducts.ToListAsync()
            };
            if (User.Identity.IsAuthenticated)
            {
                var a = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
                ViewBag.userid = a.Id;
            }
            return View(viewModel);
        }       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
