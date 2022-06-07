using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        
        public void Apply(ICreditService creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            
            foreach(var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        
        public void PreBriefTheLoan(List<ICreditService> credits)
        {
            foreach(var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
