using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //var customers = new List<customer>
            //{
            //new customer { Name = "John Smith"},
            //new customer { Name = "Mary Williams"}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //   Movie = movie,
            //  customers = customers 
            //};

            //return View();


              //      return Content("We dont have any customers yet.");
            //      return HttpNotFound();
            //         return new EmptyResult();
                     return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }


    }
}

