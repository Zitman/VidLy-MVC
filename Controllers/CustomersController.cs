using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidLy3.Models;
using VidLy3.ViewModels;
namespace VidLy3.Controllers
{
    public class CustomersController : Controller
    {
        [Route("Customers/List")]
        public ActionResult List()
        {
            var customers = GetCustomers();
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{ID}")]
        public ActionResult Details(int ID)
        {
            var customers = GetCustomers();

            var viewModel = new CustomerDetailsViewModel
            {
                Customers = customers,
                ID = ID
            };
            return View(viewModel);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}