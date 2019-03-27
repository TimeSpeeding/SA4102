using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp1.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Staff(int id, string name)
        {
            ViewData["id"] = id;
            ViewData["name"] = name;
            return View();
        }

        [Route("Department/{name1?}/ListStaff")]
        public ActionResult Department(string name1)
        {
            ViewData["name1"] = name1;
            return View();
        }
    }
}