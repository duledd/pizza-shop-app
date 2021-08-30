﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC_WebApplication.BLL.Logic.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ime je obavezno")]
        public string Name { get; set; }
        public int Price { get; set; }

        public string ProductDescription { get; set; }
        public bool Discounted { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool ProductSize { get; set; }
        public string ImagePath { get; set; }
    }
}