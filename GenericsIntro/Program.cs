namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> names = new Mylist<string>();
            names.Add("Engin");
            names.Add("Akif");
            Mylist<int> numbers = new Mylist<int> ();
            names.Show();
            Console.WriteLine(names.Count);
        }
    }
}
