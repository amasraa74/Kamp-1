using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Operator
    {
        public void Addieren(int zahl1, int zahl2)
        {
            int ergebnis = zahl1 + zahl2;
            Console.WriteLine(zahl1 + " + " + zahl2 + " = " + ergebnis);
        }
    }
}
