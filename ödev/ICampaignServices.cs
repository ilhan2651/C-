using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    interface ICampaignServices
    {

        void AddNewCampaign(Campaigns campaign);
        void DeleteNewCampaign(Campaigns campaign);
        void UpdateNewCampaign(Campaigns campaign);
        void ApplyCampaign(Campaigns campaign);
       
    }
}
