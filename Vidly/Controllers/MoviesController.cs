using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> _movie = new List<Movie>
        {
            new Movie { Id = 1, Name = "The GOD must be crazy" },
            new Movie { Id = 2, Name = "Wakanda" },
        };

        public ActionResult Index()
        {
            

            var movie = new Movie
            {
                Movies = _movie,
            };

            return View(movie);
        }

        public ActionResult Details(int id)
        {
            var movie = _movie.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
    }
}
