using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + "added");
        }

        public void listCustomer(Customer customer)
        {
            Console.WriteLine("Id:" + customer.Id);
            Console.WriteLine("Name:" + customer.Name);
            Console.WriteLine("Address:" + customer.Address);
            Console.WriteLine("-----");
        }
    }
}
