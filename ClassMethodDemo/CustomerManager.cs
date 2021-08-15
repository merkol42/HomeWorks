using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+customer.SurName+ " Adlı Kişi Eklendi!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+customer.SurName+ " Kişisi Silindi!");
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.SurName + " Listelendi!");
        }
    }
}
