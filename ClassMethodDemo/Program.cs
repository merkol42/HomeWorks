using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                Name = "Metehan",
                SurName = "Erkol",
                TelNumber = 052121212121,
            };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.List(customer);
            
            

        }
    }
}
