using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameSimulation.Abstract
{
    internal interface ISaleService
    {
        void Sale(IPlayer player, ICampaign campaign,IGame game);
    }
}
