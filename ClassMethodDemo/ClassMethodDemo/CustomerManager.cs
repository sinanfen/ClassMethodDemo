using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.TcNo + " " +customer.CustomerName + " " + customer.CustomerSurname + " " + " has been added.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.TcNo + " " + customer.CustomerName + " " + customer.CustomerSurname + " " + " has been deleted.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.TcNo + " " + customer.CustomerName + " " + customer.CustomerSurname + " " + " has been updated.");
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.TcNo);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSurname);
                Console.WriteLine(customer.CustomerAge);
            }
        }
    }
}
