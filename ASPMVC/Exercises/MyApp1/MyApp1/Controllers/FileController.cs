using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp1.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Image()
        {
            return File(Server.MapPath("~/App_Data/DVA.jpg"), "image/jpeg");
        }
    }
}