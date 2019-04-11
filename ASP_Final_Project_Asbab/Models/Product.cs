using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.Models
{
    public class Product
    {
        public Product()
        {
            UserProducts = new HashSet<UserProduct>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Name { get; set; }
        
        public string Details { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal DiscountPrice { get; set; }


        [StringLength(500)]
        public string Image { get; set; }

        public virtual ICollection<UserProduct> UserProducts { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }


        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
