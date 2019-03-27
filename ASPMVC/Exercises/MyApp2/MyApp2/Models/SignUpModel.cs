using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp2.Models
{
    public class SignUpModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public char Gender { get; set; }
        public bool AcTerms { get; set; }
    }
}