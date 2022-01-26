using System.Collections.Generic;

namespace Section03Routing.Models
{

    public class RoutingModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public Dictionary<string, string> RoutData { get; set; } = new Dictionary<string, string>();
    }
}
