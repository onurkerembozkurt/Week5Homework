using System;
using System.Collections.Generic;
using System.Text;

namespace AfterSixthWeekLesson
{
    public interface ICampaignService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
