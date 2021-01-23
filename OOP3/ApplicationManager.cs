using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //method injection yapıyoruz.
        public void DoApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            //başvuran bilgilerini değerlendirme.
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void DoCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
