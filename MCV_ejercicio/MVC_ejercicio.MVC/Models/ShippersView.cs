using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ejercicio.MVC.Models
{
    public class ShippersView
    {
        public int Id 
        {
            get; set;
        }

        public string CompanyName{ get; set; }

        public string PhoneNumber { get; set; }
    }
}