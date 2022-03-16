using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerName+" "+customer.CustomerSurname+ " Added to the system");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " Deleted from the system");
        }

        public void Listing(Customer[] customers)
        {
            foreach (Customer item in customers)
            {
                Console.WriteLine(item.CustomerName + item.CustomerSurname);
            }
        }
    }
}
