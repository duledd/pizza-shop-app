﻿using SEDC_WebApplicationEntityFactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC_WebApplication.Models
{
    public class CustomerDTO
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Required field!")]
        public string Name { get; set; }

        //[RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Your email address is not in a valid format. Example of correct format: joe.example@example.org")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }
        public int CustomerContactId { get; set; }
        public List<Order> Orders { get; set; }
        public string PicturePath { get; set; }
    }
}
