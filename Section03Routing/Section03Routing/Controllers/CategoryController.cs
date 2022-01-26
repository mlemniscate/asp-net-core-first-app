using Microsoft.AspNetCore.Mvc;
using Section03Routing.Models;

namespace Section03Routing.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            RoutingModel routingModel = new RoutingModel()
            {
                ControllerName = nameof(CategoryController),
                ActionName = nameof(Index)
            };
            return View("Result", routingModel);
        }
    }
}
