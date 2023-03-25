namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivateCustomer customer1= new PrivateCustomer();
            customer1.CustomerNo = "123245";
            customer1.FirstName = "Akif";
            customer1.LastName = "Bilgin";
            customer1.NationalId = " 1231846";
            customer1.Id = 1;

            CompanyCustomer customer2= new CompanyCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "4856465";
            customer2.CompanyName = "Firma XY";
            customer2.TaxId = "1248956456";

            Customer customer3 = new PrivateCustomer();
            Customer customer4 = new CompanyCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);




        }
    }
}