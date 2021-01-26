using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class FinanceLoanManager : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("Finance Credit payment plan created");
        }

        public void DoThings()
        {
            throw new NotImplementedException();
        }
    }
}
