using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Session05.Filters.Infrastructures;
using Session05.Filters.Models;
using System.Diagnostics;

namespace Session05.Filters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        [MyAction]
        [TypeFilter(typeof(AuthorizationSqlAttribute))]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
