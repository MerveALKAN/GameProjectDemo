using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class SalesManager : ISaleService
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            double reducedPrice;
            reducedPrice = game.GamePrice - ((game.GamePrice * campaign.CampaignDiscount) / 100);
            Console.WriteLine(game.GameName + "The game named: " + gamer.FirstName + "And the gamer named %: " + 
                campaign.CampaignDiscount + "With discount: "+ "has been sold:");

        }

        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + "The game named :" + "And the gamer named :" + gamer.FirstName + "has been sold: ");
        }

        internal void Sale(Gamer gamer, Game game)
        {
            throw new NotImplementedException();
        }
    }
}
