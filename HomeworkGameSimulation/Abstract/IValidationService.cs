using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameSimulation.Abstract
{
    internal interface IValidationService
    {
        bool Validate(IPlayer player);
    }
}
