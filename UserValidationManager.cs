using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.DateOfBirth==2001 && gamer.FirstName=="Edanur" && gamer.LastName=="Yazıcı" && gamer.IdentityNumber==69082090644)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
