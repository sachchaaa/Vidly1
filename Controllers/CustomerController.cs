using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;

namespace Vidly1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [HttpGet]
        public ActionResult customers()
        {
            return View();
        }
        public ActionResult Details1(string Name)
        {
            return Content("John Smith");
        }
        public ActionResult Details2(string Name)
        {
            return Content("Mary Williasm");
        }
        public ActionResult Details(string Name)
        {
            return Content("We dont have any customers yet." + Name);
        }
    }
}

