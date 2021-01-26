using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class TradesmanLoanManager : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("Tradesman Credit payment plan created");
        }

        public void DoThings()
        {
            throw new NotImplementedException();
        }
    }
}
