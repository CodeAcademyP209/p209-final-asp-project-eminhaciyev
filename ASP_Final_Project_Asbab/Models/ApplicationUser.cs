using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.Models
{
    public class ApplicationUser:IdentityUser
    {

        public ApplicationUser()
        {
            UserProducts = new HashSet<UserProduct>();
        }

        [Required,StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(100)]
        public string Surname { get; set; }

        public string GetFulname
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        [Required]
        public DateTime Birthdate { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        public virtual ICollection<UserProduct> UserProducts { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
