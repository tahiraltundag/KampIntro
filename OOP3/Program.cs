using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditService housingCreditManager = new HousingCreditManager();
            ICreditService needCreditManager = new NeedCreditManager();
            ICreditService vehicleCreditManager = new VehicleCreditManager();
            ICreditService artisanCreditManager = new ArtisanCreditManager();

            ILoggerService databaseLoggerManager = new DatabaseLoggerManager();
            ILoggerService fileLoggerManager = new FileLoggerManager();
            ILoggerService smsLoggerManager = new SmsLoggerManager();
            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerManager, fileLoggerManager};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(artisanCreditManager, loggers);

            List<ICreditService> credits1 = new List<ICreditService>() { needCreditManager, vehicleCreditManager};

            //applicationManager.PreBriefTheLoan(credits1);
        }
    }
}
