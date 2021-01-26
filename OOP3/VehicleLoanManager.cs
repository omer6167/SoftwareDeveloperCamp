using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class VehicleLoanManager : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit payment plan created");
        }

        public void DoThings()
        {
            throw new NotImplementedException();
        }
    }
}
