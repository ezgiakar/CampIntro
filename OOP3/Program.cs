using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface ile implementasyon yaptığım için istediğim krediyiaşağıda kullanabilirim.
            // sen bir kredimanagersın demek bu ve diğerlerinin yerine kredi managerı kullanabilrim.
            //kafa karışıklığını ve ekstra isimleri kullanmaya gerek kalmaz.

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();


            ICreditManager vehicleCreditManager = new VehicleCreditManager();


            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService>() { fileLoggerService, 
                databaseLoggerService, smsLoggerService };


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(new EsnafCreditManager() ,
               loggers);

            
            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager,
            vehicleCreditManager};

            applicationManager.DoCreditInformation(credits);

        }
    }
}
