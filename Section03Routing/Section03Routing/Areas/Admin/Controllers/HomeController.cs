using Microsoft.AspNetCore.Mvc;

namespace Section03Routing.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
