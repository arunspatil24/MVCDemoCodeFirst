using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("tblCatagory")]
    public class Catagory
    {
        [Key]
        public int CID { get; set; }
        public string CName { get; set; }
        public int Price { get; set; }
        
    }
}