using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class UserValidationManager : IE_DevletValidationServices 
    {
       public  bool Validation(Player player)
        {
            if (player.TcNo ==123456789&& player.Name=="İlhan"   && player.Surname=="Randa" &&player.BirthYear==2002 )
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
