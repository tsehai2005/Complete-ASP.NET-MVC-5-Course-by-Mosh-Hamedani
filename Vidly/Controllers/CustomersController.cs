using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Tsegay Hailemariam" },
            new Customer { Id = 2, Name = "Haftom Abadi" },
        };

        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Name = "Shrek",
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = _customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}
