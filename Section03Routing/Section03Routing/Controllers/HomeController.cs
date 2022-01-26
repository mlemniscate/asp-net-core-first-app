using Microsoft.AspNetCore.Mvc;
using Section03Routing.Models;

namespace Section03Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            RoutingModel routingModel = new RoutingModel()
            {
                ControllerName = nameof(HomeController),
                ActionName = nameof(Index)
            };
            foreach (var item in RouteData.Values)
            {
                routingModel.RoutData[item.Key] = item.Value;
            }
            return View("Result", routingModel);
        }
    }
}
