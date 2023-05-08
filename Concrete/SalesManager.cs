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

            Console.WriteLine("Oyuncu Adi: " +  player.FirstName);
            Console.WriteLine("Oyuncu Id: " + player.Id);
            Console.WriteLine("Kampanya Adi: " + campaign.CampaignName);
            Console.WriteLine("Kampanya Indirimi: " + campaign.DiscountRate);
            Console.WriteLine("Kampanyali Oyun Fiyati: " + price);

            


            Console.WriteLine("-----------------");
            Console.WriteLine("Oyun Satin Alindi");
            Console.WriteLine("-----------------");


        }
    }
}
