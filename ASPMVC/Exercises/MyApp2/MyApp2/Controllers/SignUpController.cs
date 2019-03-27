using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using MyApp2.Models;

namespace MyApp2.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult AfterRegister()
        {
            SignUpModel newSignUp = new SignUpModel();
            newSignUp.Username = Request["Username"];
            newSignUp.Password = Request["Password"];
            newSignUp.ConfirmPassword = Request["ConfirmPassword"];
            if (Request["Gender"] == "M") newSignUp.Gender = 'M';
            else newSignUp.Gender = 'F';
            if (Request["AcTerms"] == "false") newSignUp.AcTerms = false;
            else newSignUp.AcTerms = true;
            TempData["ssu"] = newSignUp;

            if (newSignUp.Password != newSignUp.ConfirmPassword) return RedirectToAction("WrongPassword");
            if (newSignUp.AcTerms == false) return RedirectToAction("NotAC");
            return RedirectToAction("Success");
        }
        public ActionResult WrongPassword()
        {
            return View();
        }
        public ActionResult NotAC()
        {
            return View();
        }
        public ActionResult Success()
        {
            ViewData["su"] = TempData["ssu"];
            return View();
        }
    }
}