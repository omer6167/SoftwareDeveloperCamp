using System;
using System.Collections.Generic;
using System.Text;
using HomeworkGameSimulation.Abstract;

namespace HomeworkGameSimulation.Concrete
{
    internal class SaleManager:ISaleService
    {
        public void Sale(IPlayer player, ICampaign campaign, IGame game)
        {
            Console.WriteLine($"{player.FirstName} {campaign.Name} Kampanyası ile  {game.Name} isimli oyunu satın aldı");
        }
    }
}
