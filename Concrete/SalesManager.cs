using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class SalesManager:ISalesService

    {

       public void Add(Player player , GameInfo gameInfo , Campaign campaign)

        {
            double price = gameInfo.GamePrice - (gameInfo.GamePrice * campaign.DiscountRate / 100);

            Console.WriteLine("Oyuncu Adi: " +  campaign.CampaignName);
            Console.WriteLine("Oyuncu Id: " + campaign.CampaignId);
            Console.WriteLine("Oyun Adi: " + gameInfo.GameName);
            Console.WriteLine("Oyun Fiyati: " + gameInfo.GamePrice);
            Console.WriteLine("Kampanya Adi: " + campaign.CampaignName);
            Console.WriteLine("Kampanya Indirimi: " + campaign.DiscountRate);
            Console.WriteLine("Kampanyali Oyun Fiyati: " + price);
            Console.WriteLine("Oyun Satin Alindi");



        }
    }
}
