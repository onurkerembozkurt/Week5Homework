using System;
using System.Collections.Generic;
using System.Text;
using Week5Homework.Abstract;
using Week5Homework.Entities;

namespace Week5Homework.Concrete
{
    public  class CustomerCheckManager : IEdevletCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
