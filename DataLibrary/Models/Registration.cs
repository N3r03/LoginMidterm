using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DataLibrary.Models
{
    public class Registration
    {
        public int id{ get; set; }

        public int UserID{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        //public string SchoolDep { get; set; }
        public string Subject { get; set; }
        public string PhoneNum { get; set; }
        //public string Year { get; set; }

    }
}
