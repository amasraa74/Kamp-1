namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary= new MyDictionary<int, string>();
            myDictionary.Add(12, "Ali");
            myDictionary.Add(4, "Hasan");
            

        }
    }
}