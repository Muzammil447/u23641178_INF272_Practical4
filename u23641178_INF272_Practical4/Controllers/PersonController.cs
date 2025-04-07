using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23641178_INF272_Practical4.Models;

namespace u23641178_INF272_Practical4.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            List<Person> people = new List<Person>();


            people.Add(new Person { Student_No = "u23641178", FirstName = "Muzammil", LastName = "Sikander Gani", Email = "u23641178@tuks.co.za", MyLink = "../HTML/Muzammil.html" });//your link needs to be in the same format as you names your file in solution explorer
            people.Add(new Person { Student_No = "u23646952", FirstName = "Ahmed", LastName = "Fyzoo", Email = "u23646952@tuks.co.za", MyLink = "../HTML/Ahmed.html" });
            people.Add(new Person { Student_No = "u23637798", FirstName = "Muaaz", LastName = "Patel", Email = "u23637798@tuks.co.za", MyLink = "../HTML/Muaaz.html" });
            people.Add(new Person { Student_No = "u24637431", FirstName = "Abdullah", LastName = "Gani", Email = "u24637431@tuks.co.za", MyLink = "../HTML/Abdullah.html" });
            people.Add(new Person { Student_No = "u25329401", FirstName = "Mohammed", LastName = "Ebrahim", Email = "u25329401@tuks.co.za", MyLink = "../HTML/Mohammed.html" });


            if (people == null)
            {
                return Content("Error: The model is null.");
            }
            return View(people);
        }
    }
}