using System;

namespace ödev
{
    class SaleManager : ISaleServices
    {
        private ICampaignServices campaignServices;
        CampaignManager campaignManager;

        

        public SaleManager(ICampaignServices campaignServices)
        {
            this.campaignServices = campaignServices;
            
        }

        

        public void order(Player player, Campaigns campaign)
        {
            Console.WriteLine("Sayın " + player.Name + " Ürün siparişiniz sisteme alınmıştır");
            campaignManager.ApplyCampaign(campaign);
         
        }
        
    }
}
