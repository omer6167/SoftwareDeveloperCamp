using System;
using System.Collections.Generic;
using System.Text;
using HomeworkGameSimulation.Abstract;

namespace HomeworkGameSimulation.Concrete
{
    internal class CampaignManager:ICampaignService
    {
        public void Add(ICampaign campaign)
        {
            Console.WriteLine($"{campaign.Name} Added");
        }

        public void Delete(ICampaign campaign)
        {
            Console.WriteLine($"{campaign.Name} Updated");
        }

        public void Update(ICampaign campaign)
        {
            Console.WriteLine($"{campaign.Name} Deleted");
        }
        
        
    }
}
