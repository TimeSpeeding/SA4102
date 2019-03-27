using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp2.Models;

namespace MyApp2.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult Index(string choice)
        {
            UserModel user = new UserModel
            {
                Name = "Zhu Yibin",
                Email = "yibin.zhu@u.nus.edu"
            };
            ViewData["user"] = user;

            if (choice == "transact")
            {
                IList<TransactModel> transacts = new List<TransactModel>();
                transacts.Add(new TransactModel() { Product = "Washing Machine", Brand = "Samsung", Price = 455 });
                transacts.Add(new TransactModel() { Product = "Bread Toaster", Brand = "Philips", Price = 35 });
                ViewData["transact"] = transacts;
            }

            else if (choice == "complain")
            {
                IList<ComplainModel> complains = new List<ComplainModel>();
                complains.Add(new ComplainModel() { Product = "Washing Machine", Complain = "Took too long to wash!" });
                complains.Add(new ComplainModel() { Product = "Bread Toaster", Complain = "Bread not crispy!" });
                ViewData["complain"] = complains;
            }

            ViewData["type"] = choice;
            return View();
        }
    }
}