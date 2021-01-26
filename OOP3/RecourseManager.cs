using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class RecourseManager
    {
        //Method injection
        public void RecourseToLoan(ICreditService creditService, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditService.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void LoanPreliminaryInformation(List<ICreditService> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}
