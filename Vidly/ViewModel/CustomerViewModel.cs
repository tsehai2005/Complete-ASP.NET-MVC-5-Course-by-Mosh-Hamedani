using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.Models
{
    public class CustomerViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}