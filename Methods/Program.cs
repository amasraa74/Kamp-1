using System.ComponentModel;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Name = "Apple";
            product1.Price = 2;
            product1.Info = "From Germany";
            

            Product product2= new Product();
            product2.Name = "Watermelon";
            product2.Price = 3.50;
            product2.Info = "From Southern-Turkey";




            Product[] products = new Product[] {product1, product2} ;
            //type-safe
            foreach (var product in products) 
            {
                Console.WriteLine("Product: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Product-Info: " + product.Info);
                Console.WriteLine("-----------------------");

            }
            Console.WriteLine("------------Methods-----------");
            WarenKorbManager warenkorbmanager = new WarenKorbManager();
            //encapsulation

            warenkorbmanager.Add(product1);
            warenkorbmanager.Add(product2);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice