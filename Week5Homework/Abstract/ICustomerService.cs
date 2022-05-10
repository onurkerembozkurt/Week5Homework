using System;
using System.Collections.Generic;
using System.Text;
using Week5Homework.Entities;

namespace Week5Homework.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
