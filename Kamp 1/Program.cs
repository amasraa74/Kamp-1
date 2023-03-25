namespace Kamp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety -
            //Do not repeat yourself
            
            string kategoriEtiketi = "Kategoriler";
            int ögreniSayisi = 32000;
            double faizOrani = 1.45;
            bool sitemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if(dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu ");
            }else if(dolarDun < dolarBugun) 
            {
                Console.WriteLine("artis butonu ");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (sitemeGirisYapmismi == true)

            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            
          

            Console.WriteLine(kategoriEtiketi);
        }
    }
}