using System;
using System.Collections.Generic;
using System.Text;
using Week5Homework.Abstract;
using Week5Homework.Entities;

namespace Week5Homework.Concrete
{
    public class CustomerManager:BaseCustomerManager
    {
       public CustomerManager(CustomerCheckManager customerCheckManager,Customer customer)
        {
            customerCheckManager.CheckIfRealPerson(customer);
        }
        public override void Save(Customer customer)
        {

            Console.WriteLine("Veri Tabanına Kaydedildi");

        }
    }
}
