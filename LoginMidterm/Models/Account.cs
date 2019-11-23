using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LoginMidterm.Models
{
    public class Account
    {
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password required")]
        
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Key]
        public int id { get; set; }
        //public bool rememberMe{ get; set;  }

    }
    

}