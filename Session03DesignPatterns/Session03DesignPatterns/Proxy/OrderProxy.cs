using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns.Proxy
{
    internal class OrderProxy : Order
    {
        public bool IsLoadedCustomer { get; set; }
        public OrderProxy(int id)
        {
            OrderId = id;
            OrderDate = DateTime.Now;
        }

        public override Customer Customer
        {
            get
            {
                if(!IsLoadedCustomer)
                {
                    base.LoadCustomer();
                }
                return base.Customer;
            }
        }
    }
}
