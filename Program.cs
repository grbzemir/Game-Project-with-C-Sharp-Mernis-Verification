using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;


namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());

            Player player1 = new Player();

            player1.Id = 1;
            player1.FirstName = "Emircan Yetkin";
            player1.LastName = "Gürbüz";
            player1.YearOfBirth = new DateTime(2003, 1, 6);
            player1.NationalityId = "12345678910";
            player1.username = "JakiesEmir";

            playerManager.Save(player1);

            Campaign campaign = new Campaign();

            CampaignManager campaignManager = new CampaignManager();

            campaign.CampaignId = 1;
            campaign.CampaignName = "Black Friday";
            campaign.DiscountRate = 50;
            campaignManager.Add(campaign);

            campaignManager = new CampaignManager();
            campaign.CampaignId = 2;
            campaign.DiscountRate = 60;
            campaign.CampaignName = "New Year";
            campaignManager.Update(campaign);

            campaignManager = new CampaignManager();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Black Friday";
            campaign.DiscountRate = 50;
            campaignManager.Remove(campaign);

            GameManager gameManager = new GameManager();
            
            GameInfo gameInfo = new GameInfo();

            gameInfo.Id = 1;
            gameInfo.GameName = "GTA 5";
            gameInfo.GamePrice = 100;
            gameInfo.GameCategory = "Action";

            gameManager.Save(gameInfo);

            gameManager = new GameManager();
            gameInfo.Id = 2;
            gameInfo.GameName = "FIFA 2023";
            gameInfo.GamePrice = 200;
            gameInfo.GameCategory = "Sports";

            gameManager.Save(gameInfo);

            gameManager = new GameManager();

            gameInfo.Id = 1;
            gameInfo.GameName = "GTA 5";
            gameInfo.GamePrice = 100;
            gameInfo.GameCategory = "Action";
            gameManager.Save(gameInfo);

            SalesManager salesManager = new SalesManager();
            salesManager.Add(player1, gameInfo, campaign );

            Player player2 = new Player();

            player2.Id = 2;
            player2.FirstName = "Bilge";
            player2.LastName = "Uzun";
            player2.YearOfBirth = new DateTime(2003 , 6 , 25);
            player2.NationalityId = "12345678910";
            player2.username = "LadyBilge";

            campaignManager = new CampaignManager();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Black Friday";
            campaign.DiscountRate = 50;
            campaignManager.Add(campaign);


            playerManager.Save(player2);


        }

    }

}
