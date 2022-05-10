using System;
using System.Collections.Generic;
using System.Text;

namespace AfterSixthWeekLesson
{
    class CampaingManager : ICampaignService
    {
        IOrderService _iorderService;
        public CampaingManager(IOrderService iorderService)
        {
            _iorderService = iorderService;
        }
        public void Add(Gamer gamer)
        {
            _iorderService.AddOrder(gamer);
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Gamer gamer)
        {
            _iorderService.RemoveOrder(gamer);
            Console.WriteLine("Order iptal oldugu için kampanya eklenmedi mantıken");
        }

        public void Update(Gamer gamer)
        {
            _iorderService.UpdateOrder(gamer);
            Console.WriteLine("Order sayısı veya ürün degisti mantıken kampanya ya degisti ya da kampanyasız ürün geldi");
        }
    }
}
