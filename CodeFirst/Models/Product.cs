using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Product
    {
        public int ID { get; set; }
        //[Required(ErrorMessage = "Number of years is required")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Number of years is required")]
        public int Price { get; set; }
        //[Required(ErrorMessage = "Number of years is required")]
        public string Description { get; set; }
    }
}