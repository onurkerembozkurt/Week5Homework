using System;
using System.Collections.Generic;
using System.Text;

namespace AfterSixthWeekLesson
{
    public class OrderManager : IOrderService
    {
        public void AddOrder(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+"Sipariş verdi");
        }

        public void RemoveOrder(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "Siparişi Kaldırdı");
        }

        public void UpdateOrder(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+"Siparişi Güncelledi");
        }
    }
}
