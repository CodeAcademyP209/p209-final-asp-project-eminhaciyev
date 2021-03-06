﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Final_Project_Asbab.Models
{
    public class NewArrival
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Required,StringLength(400)]
        //public string Title { get; set; }

        [Required,StringLength(100)]
        public  string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public decimal DiscountPrice { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }


        
    }
}
