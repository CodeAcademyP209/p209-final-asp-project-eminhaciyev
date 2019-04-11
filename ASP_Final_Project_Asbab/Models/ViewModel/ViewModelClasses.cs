using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.Models.ViewModel
{
    public  class ViewModelClasses
    {
        public Product Product { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public Category Category { get; set; }

        public IEnumerable<Header> Header { get; set; }

        public IEnumerable<NewArrival> NewArrival { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<Product> ProductRated { get; set; }

        public IEnumerable<OurBlog> OurBlog { get; set; }

        public OurBlog OurBlogs { get; set; }


        public List<UserProduct> UserProduct { get; set; }

    }
}
