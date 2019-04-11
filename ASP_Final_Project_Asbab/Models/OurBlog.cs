using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.Models
{
    public class OurBlog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Date { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
