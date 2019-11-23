using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace LoginMidterm.Models
{
    public class Registration
    {
        public int id { get; set; }
        [Required(ErrorMessage = "User Id required")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "First Name required")]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }
       
        public string Subject { get; set; }
        [Required(ErrorMessage = "Phone number required")]
        public string PhoneNum { get; set; }
       

    }
}