using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class PlayerManager : IPlayerServices
    {
        IE_DevletValidationServices e_DevletValidationServices;

        public PlayerManager(IE_DevletValidationServices e_DevletValidationServices)
        {
            this.e_DevletValidationServices = e_DevletValidationServices;
        }


        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Register(Player player)
        {

            if (e_DevletValidationServices.Validation(player) == true)
            {
             Console.WriteLine("kayıt Olundu");
            } 
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt Başarısız");
            }

           
        }

        public void Update(Player player)
        {
            Console.WriteLine("kayıt Güncellendi");
        }
    }
}
