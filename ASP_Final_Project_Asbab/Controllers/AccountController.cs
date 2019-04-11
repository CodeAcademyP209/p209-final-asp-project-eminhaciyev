using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Final_Project_Asbab.Data;
using ASP_Final_Project_Asbab.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Final_Project_Asbab.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AsbabDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 RoleManager<IdentityRole> roleManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 AsbabDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register register)
        {
            if (!ModelState.IsValid) return View(register);

            var user = new ApplicationUser()
            {
                Name = register.Name,
                Surname = register.Surname,
                UserName = register.Email,
                Birthdate = register.Birthdate,
                Email = register.Email,
            };

            var result = await _userManager.CreateAsync(user, register.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }

            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Register", "Account");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            if (!ModelState.IsValid) return View(login);

            var user = await _userManager.FindByEmailAsync(login.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View(login);
            }

            var result = await _signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Please wait 5 minutes.Your Account is blocked...");
                return View(login);
            }

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View(login);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Profile()
        {
            return View();
        }

    }
}