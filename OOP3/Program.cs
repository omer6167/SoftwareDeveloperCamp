using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICreditService financeCreditManager = new FinanceLoanManager();
            ICreditService vehicleLoanManager = new VehicleLoanManager();
            ICreditService mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() }; //new SmsLoggerService(), new FileLoggerService()


            RecourseManager recourseManager = new RecourseManager();
            recourseManager.RecourseToLoan(new MortgageLoanManager(), loggers);

            List<ICreditService> creditServices = new List<ICreditService>() { financeCreditManager, vehicleLoanManager };

            recourseManager.LoanPreliminaryInformation(creditServices);


            Console.ReadLine();
        }
    }
}
