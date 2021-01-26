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
            if (_eDevletValidation.Validate(player))
            {
                Console.WriteLine($"{player.FirstName} Added");
            }
            else
            {
                Console.WriteLine("Player is invalid");
            }
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
