using System;
using System.Collections.Generic;
using System.Text;
using HomeworkGameSimulation.Abstract;

namespace HomeworkGameSimulation.Concrete
{
    internal class Campaign :ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime Duration { get; set; }
    }
}
