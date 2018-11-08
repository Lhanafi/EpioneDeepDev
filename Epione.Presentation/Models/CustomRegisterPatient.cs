using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Epione.Presentation.Models
{
    public class CustomRegisterPatient : RegisterViewModel
    {
       
        
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Telephone { get; set; }

        public string address { get; set; }
        public string RoleUser { get; set; }

        public string Social_Number { get; set; }

    }
}