using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidLy3.Models;
using VidLy3.ViewModels;

namespace VidLy3.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie {Id = 1, Name = "Shrek!"};

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie
            };

            return View(viewModel);
        }

        [Route("movies/List")] // a comment
        public ActionResult List()
        {
            var movies = GetMovies();

            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(string.Format("Year: {0}, Month: {1}", year, month));
        }

        [Route("movies/released2/{year}/{month}")]
        public ActionResult ByReleaseDate2(int year, int month)
        {
            return Content(string.Format("2 - Year: {0}, Month: {1}", year, month));
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie() {Id = 1, Name = "Shrek!"},
                new Movie() {Id = 2, Name = "Wall-E"}
            };

        }
    }
}

//return Content("Hello");
//return HttpNotFound();
//return new EmptyResult();
//return RedirectToAction("Index", "Home", new { Page = 1, sortBy = "name" });
