using Microsoft.AspNetCore.Mvc;
using Section01Test.Models;

namespace Section01Test.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepo customerRepo;

        public CustomerController(ICustomerRepo customerRepo)
        {
            this.customerRepo = customerRepo;
        }
        public IActionResult Index()
        {
            return View(customerRepo.GetAll());
        }
        public IActionResult Search()
        {
            return View(customerRepo.Search("M"));
        }

        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Customer customer)
        {
            customerRepo.Add(customer);
            return RedirectToAction("Index");
        }
    }
}
