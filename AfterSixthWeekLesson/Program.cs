using System;

namespace AfterSixthWeekLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //gamerManager.Add(new Gamer{ Id = 1, BirthYear = 2001, FirstName = "Kerem", IdentityNumber = 123, LastName = "Bozkurt" });

            //IUserValidationService deneme = new UserValidationManager();
            Gamer gamer = new Gamer();
            gamer.FirstName = "Kerem";
            gamer.LastName = "Bozkurt";
            gamer.BirthYear = 2001;
            gamer.Id = 1;
            gamer.IdentityNumber = 23213231231;
            CampaingManager campaingManager = new CampaingManager(new OrderManager());
            campaingManager.Add(gamer);
            campaingManager.Delete(gamer);
            campaingManager.Update(gamer);
            
        }
    }
}
//3.10 gerekirse bir daha izle