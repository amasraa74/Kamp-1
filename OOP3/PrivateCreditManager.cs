using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PrivateCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Beispiel Kredit für Privat wurde errechnet");
        }

        public void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }
}
