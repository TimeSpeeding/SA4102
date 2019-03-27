using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp2.Models;

namespace MyApp2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListBooks()
        {
            IList<Book> booklist = new List<Book>();
            booklist.Add(new Book() { BookId = 22, Title = "Over The Rainbow", Author = "J.R. Low", YearPublished = 1998 });
            booklist.Add(new Book() { BookId = 23, Title = "Tin Tin", Author = "John Long", YearPublished = 2010 });
            booklist.Add(new Book() { BookId = 24, Title = "Molly Goes To School", Author = "M. Martin", YearPublished = 2011 });
            ViewData["bl"] = booklist;
            return View();
        }
    }
}