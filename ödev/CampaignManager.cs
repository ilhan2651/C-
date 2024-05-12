using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class CampaignManager : ICampaignServices
    {
        public void AddNewCampaign(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName+" Kampanyalar Listesine Eklendi.");
        }

        public void DeleteNewCampaign(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName+  " Kampanyalar Listesinden Silindi" );
        }

        public void ApplyCampaign(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Kampanyanız uygulandı");
        }

        public void UpdateNewCampaign(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName+ "Güncellendi") ;
        }

        
        }
    }

