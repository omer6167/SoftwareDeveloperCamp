using System;
using System.Collections.Generic;
using System.Text;
using HomeworkGameSimulation.Abstract;

namespace HomeworkGameSimulation.Concrete
{ 
    internal class PlayerManager
    {
        private EDevletValidation _eDevletValidation;
        
        public PlayerManager()
        {
            
        }
        public void Add(IPlayer player)
        {
            _eDevletValidation = new EDevletValidation();
            Console.WriteLine(_eDevletValidation.Validate(player) ? $"{player.FirstName} Added" : "Player is invalid");
        }
        public void Update(IPlayer player)
        {
            Console.WriteLine($"{player.FirstName} Updated");
        }
        public void Delete(IPlayer player)
        {
            Console.WriteLine($"{player.FirstName} Deleted");
        }
    }
}
