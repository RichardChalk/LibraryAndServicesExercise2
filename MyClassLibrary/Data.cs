using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public static class Data
    {
        public static List<Customer> Customers { get; set; }
        public static int IdSeed { get; set; } = 10;
        public static void SeedData()
        {
            Customers = new List<Customer>
            {
                new Customer(1, "Cust1", "Email1"),
                new Customer(2,"Cust2", "Email2"),
                new Customer(3,"Cust3", "Email3"),
                new Customer(4,"Cust4", "Email4"),
                new Customer(5,"Cust5", "Email5"),
                new Customer(6,"Cust6", "Email6"),
                new Customer(7,"Cust7", "Email7"),
                new Customer(8,"Cust8", "Email8"),
                new Customer(9,"Cust9", "Email9"),
                new Customer(10,"Cust10", "Email10")
            };
        }
    }
}
