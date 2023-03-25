using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RequestManager
    {
        //Method injection
        public void Request(ICreditManager creditManager, ILoggerService loggerService)
        {

            creditManager.Calculate();
            loggerService.Log();
            

        }
        public void CreditInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
