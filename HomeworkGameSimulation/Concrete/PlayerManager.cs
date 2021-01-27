using System;
using System.Collections.Generic;
using System.Text;
using HomeworkGameSimulation.Abstract;

namespace HomeworkGameSimulation.Concrete
{ 
    internal class PlayerManager
    {
        private IValidationService _validationService;
        
        public PlayerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }
        public void Add(IPlayer player)
        {
            Console.WriteLine(_validationService.Validate(player) ? $"{player.FirstName} Added" : "Player is invalid");
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
