using ASP_Final_Project_Asbab.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ASP_Final_Project_Asbab.Data
{
    public class AsbabDbContext:IdentityDbContext<ApplicationUser>
    {
        public AsbabDbContext(DbContextOptions<AsbabDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Header> Headers { get; set; }

        public DbSet<NewArrival> NewArrivals { get; set; }

        public DbSet<OurBlog> OurBlogs { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<UserProduct> UserProducts { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

       

    }
}
