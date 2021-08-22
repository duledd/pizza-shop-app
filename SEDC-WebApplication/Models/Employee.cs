﻿using SEDC_WebApplication.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC_WebApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field!")]
        public string Name { get; set; }
        public string Email { get; set; }
        public RoleEnum Role { get; set; }
        public string Pol { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Picture { get; set; }
    }
}