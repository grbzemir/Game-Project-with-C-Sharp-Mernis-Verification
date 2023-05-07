using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    internal class CampaignManager:ICampaignService
    
    {

        public void Add(Campaign campaign)

        {
            Console.WriteLine("Campaign Added" + campaign.CampaignName + " " + campaign.DiscountRate + " " + campaign.CampaignId);
        }

        public void Remove(Campaign campaign)

        {
            Console.WriteLine("Campaign Removed" + campaign.CampaignName + " " + campaign.DiscountRate + " " + campaign.CampaignId);
        }

        public void Update(Campaign campaign)

        {

            Console.WriteLine("Campaign Updated" + campaign.CampaignName + " " + campaign.DiscountRate + " " + campaign.CampaignId);
        }
    }
}
