using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.Models
{
    public class Header
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Title { get; set; }

        [Required,StringLength(100)]
        public string Body { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
