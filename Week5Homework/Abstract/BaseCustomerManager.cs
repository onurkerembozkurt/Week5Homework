using System;
using System.Collections.Generic;
using System.Text;
using Week5Homework.Concrete;
using Week5Homework.Entities;

namespace Week5Homework.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        
        public virtual void Save(Customer customer)
        {
             
        }
    }
}
