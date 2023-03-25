namespace WertUndReferenzTypen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 10;
            int zahl2 = 30;
            zahl1 = zahl2;
            zahl2 = 65;
            //zahl1 ?
            Console.WriteLine(zahl1);

            int[] zahlen1 = new int[] {10, 20,30};
            int[] zahlen2 = new int[] { 100, 200, 300 };
            zahlen1= zahlen2;
            zahlen2[0] = 999;
            //zahlen1[0}?
            Console.WriteLine(zahlen1[0]);
            
        }
    }
}