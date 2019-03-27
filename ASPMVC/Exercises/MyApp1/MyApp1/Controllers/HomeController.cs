using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using MyApp1.Models;

namespace MyApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //Exercises04
            //Demo demo = new Demo();
            //demo.name = "Hello!";
            //Debug.WriteLine("Debug okay!");

            Demo demo = new Demo()
            {
                name = "Hello"
            };
                        
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            //Exercises05
            Data data = new Data();
            data.Greeting = "Hello there!";
            data.From = "This is Home controller";
            ViewData["data1"] = data;
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetDepartment(string department, string course)
        {
            Debug.WriteLine(department);
            Debug.WriteLine(course);

            return View();
        }

        public ActionResult GetDepartment2(Entity entity)
        {
            Debug.WriteLine(entity.Department);
            Debug.WriteLine(entity.Course);

            return View();
        }

        public ActionResult CreateDepartment(Entity entity1)
        {
            entity1.Department = Request["department"];
            entity1.Course = Request["course"];
            ViewData["entity"] = entity1;

            return View();
        }
    }
}