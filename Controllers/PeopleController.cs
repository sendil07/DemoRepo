using System.Web.Mvc;
using MusicStore.Models;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MusicStore.Controllers
{
    public class PeopleController : Controller
    {
        private Person[] personData = {
                                    new Person {FirstName = "Adam", LastName = "Freeman", Role = Role.Admin},
                                    new Person {FirstName = "Steven", LastName = "Sanderson", Role = Role.Admin},
                                    new Person {FirstName = "Jacqui", LastName = "Griffyth", Role = Role.User},
                                    new Person {FirstName = "John", LastName = "Smith", Role = Role.User},
                                    new Person {FirstName = "Anne", LastName = "Jones", Role = Role.Guest}
                                    };


        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "New York", "London", "Paris" };
            string message = "This is an HTML element: <input>";
            return View(personData);
        }

        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }

        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<Person> data = personData;
            if (selectedRole != "All")
            {
                Role obj = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = personData.Where(p => p.Role == obj);
            }
            return PartialView(data);
        }
    }
}
