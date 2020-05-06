using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> n = new MyList<int>();
            n.Add(5);
            System.Console.WriteLine(n.Length);
            n.Add(8);
            n.Add(9);
            foreach(var m in n.GetAll(20))
            System.Console.WriteLine(m);
            MyDictionary<string, string> city = new MyDictionary<string, string>();
            city.Add("Spain", "Madrid");
            city.Add("Kuba", "Gavana");
            city.Add("Livia", "Tripoli");
        }
    }
}
