using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        private List<Customer> GetCustomers()
        {
            return (new List<Customer>
        {
            new Customer { Id = 1, Name = "Wedi Hailemariam" },
            new Customer { Id = 2, Name = "Haftom Abadi" },
        }
                
                );

        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
    }
}
