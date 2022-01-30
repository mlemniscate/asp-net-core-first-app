using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03DesignPatterns.Proxy
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Order
    {
        public Order()
        {

        }
        public Order(int id)
        {
            //Load From Db
            OrderId = id; 
            OrderDate = DateTime.Now;
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            // Load Customer From Db
            Customer = new Customer
            {
                FirstName = "Milad",
                LastName = "Abdi"
            };
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
