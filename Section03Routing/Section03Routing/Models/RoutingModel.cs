using System.Collections.Generic;

namespace Section03Routing.Models
{

    public class RoutingModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public Dictionary<string, object> RoutData { get; set; } = new Dictionary<string, object>();
    }
}
