using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MTVideos.Models;
using MTVideos.ViewModels;
using System.Data.Entity.Validation;

namespace MTVideos.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            return View(movies);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movies movies)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Genres = _context.Genres.ToList()

                };

                return View("MovieForm", viewModel);
            }

            if (movies.Id == 0)
            {
                movies.DateAdded = DateTime.Now;
                _context.Movies.Add(movies);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movies.Id);
                movieInDb.Name = movies.Name;
                movieInDb.NumberInStock = movies.NumberInStock;
                movieInDb.GenreId = movies.GenreId;
                movieInDb.DateReleased = movies.DateReleased;

            }
           
            
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if  (movie == null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieFormViewModel
            {
                Movies = movie,
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }
    }
}