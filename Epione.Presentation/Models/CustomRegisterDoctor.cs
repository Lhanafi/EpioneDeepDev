using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Epione.Presentation.Models
{
    public enum Speciality
    {
        ophtalmologist,
        psychiatrist

    }

    public class CustomRegisterDoctor:RegisterViewModel
    {

        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Telephone { get; set; }

        public string address { get; set; }
        public string RoleUser { get; set; }
        public int registration_number { get; set; }
        public string Office_address { get; set; }
        public string speciality { get; set; }


    }
}