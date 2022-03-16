using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerId = 123456;
            customer.CustomerName = "Ali";
            customer.CustomerSurname = "Huseynov";

            Customer customer1 = new Customer();
            customer1.CustomerId = 123457;
            customer1.CustomerName = "Farid";
            customer1.CustomerSurname = "Huseynov";

            Customer customer2 = new Customer();
            customer2.CustomerId = 123458;
            customer2.CustomerName = "Javid";
            customer2.CustomerSurname = "Guseynov";

            Customer customer3 = new Customer();
            customer3.CustomerId = 123459;
            customer3.CustomerName = "Ali";
            customer3.CustomerSurname = "Huseynov";

            Customer[] customers = { customer, customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Remove(customer3);
            customerManager.Listing(customers);

        }
    }
}
