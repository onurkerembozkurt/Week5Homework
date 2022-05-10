using System;
using System.Collections.Generic;
using System.Text;
using Week5Homework.Abstract;
using Week5Homework.Entities;

namespace Week5Homework.Concrete
{
    public class ProductManager
    {
        public void AddProduct(Customer customer)
        {
            Console.WriteLine("Ürün satın alındı" + customer.FirstName);
        }
      

       


    }
}
