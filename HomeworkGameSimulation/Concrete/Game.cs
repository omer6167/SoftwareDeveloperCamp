using System;
using System.Collections.Generic;
using System.Text;
using HomeworkGameSimulation.Abstract;

namespace HomeworkGameSimulation.Concrete
{
    internal class Game :IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
