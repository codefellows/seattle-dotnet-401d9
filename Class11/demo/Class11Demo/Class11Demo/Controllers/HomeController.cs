using Class11Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class11Demo.Controllers
{
    public class HomeController : Controller
    {
        // create our default action from our default routing
        [HttpGet]
        public ViewResult Index()
        {
            /* To find our view. we must
             * 1. Create a folder named "Views"
             * 1. Create another folder (inside Views) that is the same name as the controller (w/o the word controller)
             * 1. Create a .cshtml file that is the same name as the action we are creating the page for
             */
            return View();
        }

        [HttpPost]
        public IActionResult Index(string firstName, string lastName, int age)
        {
            Student student = new Student(firstName, lastName, age);
            return RedirectToAction("Results", student);
        }

        public ViewResult Results(Student student)
        {
            return View(student);

        }

        public IActionResult AllStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{FirstName = "Kate", LastName="Austin", Age=50 },
                new Student{FirstName = "James", LastName = "Ford", Age = 46},
                new Student{FirstName = "Hugo", LastName="Reyes", Age=63},
                new Student{FirstName = "Jack", LastName="Shepard", Age=23},
                new Student{FirstName = "Juliet", LastName="Burke", Age=35},
            };

            return View(students);
        }

        // localhost:XXXX?name=Amanda&age=50
        public string Drats(string name, int age)
        {
            // The ability to associate a URL query with the parameter is called "Model Binding"
            return $"Hello {name}, you are {age} years old";
        }


    }
}
