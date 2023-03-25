namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilimci Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";

            //array 
            string[] kurslar = new string[] {kurs1, "Programlamaya baslangic icin temel kurs","Java", "Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}