using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine("{0} adlı oyuncu {1} oyununu satın aldı.", gamer.Name, game.Name);
        }

        public void SellCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("{0} adlı oyuncu {1} oyununu {2} kampanyası ile satın aldı.", gamer.Name, game.Name, campaign.Name);
        }
    }
}
