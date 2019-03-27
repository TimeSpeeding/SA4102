using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
    }
}