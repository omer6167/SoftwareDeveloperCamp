using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameSimulation.Abstract
{
    internal interface IGame
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}
