using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class CarCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Beispiel Kredit für Auto wurde errechnet");
        }

        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }
}
