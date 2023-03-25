using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class WarenKorbManager
    {
        public void Add(Product product)
             
        {
            Console.WriteLine("In den Warenkorb hinzugefügt : " + product.Name);
            
        }
       
    }
}
