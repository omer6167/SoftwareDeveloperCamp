using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class MortgageLoanManager : ICreditService
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Credit payment plan created");
        }

        public void DoThings()
        {
            throw new NotImplementedException();
        }
    }
}
