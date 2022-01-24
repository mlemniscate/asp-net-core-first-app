using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Section01Test.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface ICustomerRepo
    {
        void Add(Customer customer);
        List<Customer> GetAll();
        List<Customer> Search(string firstName);
        string GetForExport();
    }

    public class CustomerRepo : ICustomerRepo
    {
        private readonly List<Customer> db = new List<Customer>
        {
            new Customer{Id = 1, FirstName ="Milad", LastName = "Abdi"},
            new Customer{Id = 1, FirstName ="Saman", LastName = "Arshadi"},
        };
        public void Add(Customer customer)
        {
            customer.Id = db.Count + 1;
            db.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return db;
        }

        public string GetForExport()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in db)
            {
                stringBuilder.Append($"{item.Id},{item.FirstName},{item.LastName}");
            }
            return stringBuilder.ToString();
        }

        public List<Customer> Search(string searcheString)
        {
            return db.Where(c => c.FirstName.Contains(searcheString)).ToList();
        }
    }
}
