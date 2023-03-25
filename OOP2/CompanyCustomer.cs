using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Inheritance / Vererbung
    internal class CompanyCustomer : Customer
    {

        public string CompanyName { get; set; }

        public string TaxId { get; set; }
    }
}
