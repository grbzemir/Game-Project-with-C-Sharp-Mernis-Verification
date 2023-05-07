using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Campaign

    {
        public int CampaignId { get; set; } // kampanya id
        public string CampaignName { get; set; } // kampanya adı
        public float DiscountRate { get; set; } // indirim oranı
    }
}
