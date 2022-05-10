using System;
using System.Collections.Generic;
using System.Text;
using Week5Homework.Abstract;

namespace Week5Homework.Entities
{
    public class Customer:IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcId { get; set; }

    }
}
