using ConfigurationMVC.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ConfigurationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly SiteUpTime siteUpTime;

        public HomeController(SiteUpTime siteUpTime)
        {
            this.siteUpTime = siteUpTime;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
