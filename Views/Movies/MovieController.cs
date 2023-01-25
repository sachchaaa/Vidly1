using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly1.Views.Movies
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult MOVIE()
        {
            return View();
        }
        public ActionResult MOVIE_Details1(string Name)
        {
            return Content("Shrek");
        }
        public ActionResult MOVIE_Details2(string Name)
        {
            return Content("Wall-e");
        }
    }
}