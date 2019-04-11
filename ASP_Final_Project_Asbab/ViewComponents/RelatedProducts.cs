using ASP_Final_Project_Asbab.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.ViewComponents
{
    public class RelatedProducts:ViewComponent
    {
        private readonly AsbabDbContext _context;

        public RelatedProducts(AsbabDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId, int categoryId)
        {
            var product = await _context.Products.Where(c => c.CategoryId == categoryId && c.Id == productId).ToListAsync();
            return View(product);
        }
    }
}
