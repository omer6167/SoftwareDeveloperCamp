using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameSimulation.Abstract
{
    interface ICampaignService
    {
        void Add(ICampaign campaign);
        void Delete(ICampaign campaign);
        void Update(ICampaign campaign);
    }
}
