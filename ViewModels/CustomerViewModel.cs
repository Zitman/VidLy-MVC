using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidLy3.Models;

namespace VidLy3.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }
    }

    public class CustomerDetailsViewModel
    {
        public List<Customer> Customers { get; set; }
        public int ID;
    }

}