using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {

            Campaigns campaign1 = new Campaigns();
            campaign1.CampaignName = "Student Campaign";
            campaign1.DiscountPercentage = 30;
            Campaigns campaign2 = new Campaigns();
            campaign2.CampaignName = "New Customer Campaign";
            campaign2.DiscountPercentage = 40;



            Player player1 = new Player();
            player1.TcNo = 123456789;
            player1.Name = "İlhan";
            player1.Surname = "Randa";
            player1.BirthYear = 2002;
            

              PlayerManager playerManager = new PlayerManager(new UserValidationManager());
              SaleManager saleManager = new SaleManager( new CampaignManager());
              playerManager.Register(player1);
              saleManager.order(player1,campaign1);

          

            Player player2 = new Player();
            player2.TcNo = 123456780;
            player2.Name = "İlker";
            player2.Surname = "Randa";
            player2.BirthYear =2012;


            



           


            Console.ReadKey();



        }
    }
}
