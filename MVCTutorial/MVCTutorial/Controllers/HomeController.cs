// Advanced Software and Web Developer Diploma
// Part X: C# and .NET Framework - Part 2
// by Pitman Training / The Tech Academy

// MODULE 11: Creating MVC Applications
// AUTHOR: Steven Partlow
// DATE: 25/02/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models; // Use any Model we have defined

namespace MVCTutorial.Controllers
{

    public class HomeController : Controller
    {

        public ActionResult Index() // A method to call the Index view
        {
            User user = new User(); // Create a new instance of the user Model

            // Set the properties of the user Model
            user.Id = 1;
            user.FirstName = "Steven";
            user.LastName = "Partlow";
            user.Age = 43;

            return View(user); // Return the Index view passing in the user model object
        } // End INDEX

        public ActionResult About() // A method to call the About view
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View(); // Return the About view passing in the user model object
        } // End ABOUT

        public ActionResult Contact(int id = 0) // A method to call the Contact view
        {
            ViewBag.Message = id;

            return View(); // Return the Contact view passing in the user model object
        } // End CONTACT

    } // End CLASS HomeController

} // End MVCTutorial.Controllers NAMESPACE