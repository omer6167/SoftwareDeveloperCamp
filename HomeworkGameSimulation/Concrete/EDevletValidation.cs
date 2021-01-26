using System;
using System.Collections.Generic;
using System.Text;
using HomeworkGameSimulation.Abstract;

namespace HomeworkGameSimulation.Concrete
{
    internal class EDevletValidation:IValidationService
    {
        public bool Validate(IPlayer player)
        {
            
            if (player.IdentityNo.Length !=11) // Can be added new constraint or can be controlled from the system
            {
                return false;
            }

            return true;
        }
    }
}
