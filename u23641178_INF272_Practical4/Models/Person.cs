using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u23641178_INF272_Practical4.Models
{
    public class Person
    {
        [Display(Name = "Student Number")]
        public string Student_No { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Link to Personal Page")]
        public string MyLink { get; set; }

        [Display(Name = "Delete")]
        public string Delete { get; set; }
    }
}