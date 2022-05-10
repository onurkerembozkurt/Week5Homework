using System;
using System.Collections.Generic;
using System.Text;

namespace AfterSixthWeekLesson
{
    public interface IOrderService
    {
        void AddOrder(Gamer gamer);
        void RemoveOrder(Gamer gamer);
        void UpdateOrder(Gamer gamer);


    }
}
