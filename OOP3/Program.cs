using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager privateCreditManager = new PrivateCreditManager();
            ICreditManager carCreditManager = new CarCreditManager();
            ICreditManager buildingCreditManager = new BuildingCreditManager();  
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RequestManager requestManager = new RequestManager();

            requestManager.Request(carCreditManager, dataBaseLoggerService);


            List<ICreditManager> credit = new List<ICreditManager>() {privateCreditManager, carCreditManager, buildingCreditManager};
            requestManager.CreditInfo(credit);
            


            
        }
    }
}