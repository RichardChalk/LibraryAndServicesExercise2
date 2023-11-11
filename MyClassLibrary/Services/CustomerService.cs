using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyClassLibrary.Services
{
    public class CustomerService
    {
        public List<Customer> Customers { get; set; }

        public CustomerService()
        {
            Customers = Data.Customers;
        }
        public List<Customer> Create()
        {
            Console.WriteLine("Vad heter din nya kund?");
            var name = Console.ReadLine();
            Console.WriteLine("Emailadress?");
            var email = Console.ReadLine();
            ++Data.IdSeed;
            var customer = new Customer(Data.IdSeed, name, email);
            Data.Customers.Add(customer);
            return Data.Customers;
        }

        public Customer ReadOne(int customerId)
        {
            var customerToReturn = Data.Customers.Find(c => c.CustomerId == customerId);
            if (customerToReturn == null)
            {
                return null;
            }
            return customerToReturn;
        }

        public List<Customer> ReadAll()
        {
            return Data.Customers.ToList();
        }

        public void Update(int customerId)
        {
            var customerToUpdate = Data.Customers.Find(c => c.CustomerId == customerId);
            if (customerToUpdate == null)
            {
                return;
            }

            Console.WriteLine("Uppdatera namnet på din kund");
            var name = Console.ReadLine();
            Console.WriteLine("Uppdatera Emailadressen på din kund");
            var email = Console.ReadLine();

            customerToUpdate.Name = name;
            customerToUpdate.Email = email;
        }

        public void Delete(int customerId)
        {
            var customerToDelete = Data.Customers.Find(c => c.CustomerId == customerId);
            if (customerToDelete == null)
            {
                return;
            }
            Customers.Remove(customerToDelete);
        }
    }
}
