using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface ICampaignService

    {

        void Add(Campaign campaign);
        void Remove(Campaign campaign);

        void Update(Campaign campaign);

    }
}
