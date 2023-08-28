using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movie = GetMovie();
            return View(movie);
        }

        private List<Movie> GetMovie()
        {
            return (
                new List<Movie>
                    {
                        new Movie { Id = 1, Name = "The GOD must be crazy" },
                        new Movie { Id = 2, Name = "Wakanda" },
                    }
                );
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovie().SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
    }
}
