using System;
using System.Collections.Generic;
using System.Text;

namespace AfterSixthWeekLesson
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2001 && gamer.FirstName == "Kerem" && gamer.LastName == "Bozkurt")
            {
                return true;
            }
            else
                return false;
        }
    }
}
