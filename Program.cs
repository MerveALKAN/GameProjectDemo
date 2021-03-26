using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
      public  static void Main(string[] args)
        {
        BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
           
            Gamer gamer = new Gamer() 
            {   GamerId = 1, 
                NationalityId = "52753464950", 
                FirstName ="Merve", 
                LastName ="ALKAN", 
                DateOfBirth = new System.DateTime(1998,6,7) 
            };

            gamerManager.Add(gamer);
            gamerManager.Remove(gamer);
            gamerManager.Update(gamer);

            Game game = new Game()
            {
                GameId = 2,
                GameName = "Dota 2",
                GameDescription = "A Modern Multiplayer Masterwork",
                GamePrice = 150

            };

            GameManager gameManager = new GameManager();        
            gameManager.Add(game);
            gameManager.Update(game);      
            gameManager.Delete(game);

            Campaign campaign = new Campaign()
            {
                CampaignId = 3,
                CampaignDiscount = 20,
                CampaignName = "Dota 2 Discount"
            };
            CampaignManager campaignManager = new CampaignManager();    
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);  
            campaignManager.Delete(campaign);

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(gamer,game);
            salesManager.CampaignSale(gamer,game,campaign);

            Console.ReadLine();


        }
    }
}
