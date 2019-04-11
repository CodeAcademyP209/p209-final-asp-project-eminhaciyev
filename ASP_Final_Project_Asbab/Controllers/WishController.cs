using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using ASP_Final_Project_Asbab.Models;
using ASP_Final_Project_Asbab.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_Final_Project_Asbab.Controllers
{
    public class WishController : Controller
    {
        private readonly AsbabDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public WishController(AsbabDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Wishlist()
        {
            string alkazer = "";
            if (User.Identity.IsAuthenticated)
            {
                var a = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
                alkazer = a.Id;
                ViewBag.userid = a.Id;
            }

            //string currentUser = _userManager.GetUserAsync(HttpContext.User).Id.ToString();
            //ViewBag.currentUser = currentUser;
            var viewModel = new ViewModelClasses
            {
                //Products = await _context.Products.ToListAsync(),
                UserProduct = await _context.UserProducts.Where(x => x.ApplicationUser.Id == alkazer).ToListAsync()
            };
            return View(viewModel);
        }

        public async Task<IActionResult> SetFavourites(string userid, int id)
        {
            UserProduct userProduct = new UserProduct();
            userProduct.ApplicationUserId = _userManager.GetUserId(User);
            userProduct.ProductId = id;

            _context.UserProducts.Add(userProduct);
            await _context.SaveChangesAsync();

            return Content("code = 200 ");
        }

        public async Task<IActionResult> DelFavourites(string userid, int id)
        {
            //var currentUser = _userManager.GetUserId(User);
            _context.UserProducts.Remove(_context.UserProducts.Where(x => x.ApplicationUserId == userid && x.ProductId == id).FirstOrDefault());
            await _context.SaveChangesAsync();

            return Content("code = 200 ");
        }


    }
}