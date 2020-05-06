using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> n = new MyList<int>();
            n.Add(5);
            n.Add(8);
            n.Add(9);
            System.Console.WriteLine(n.Length);
            foreach(var m in n.GetAll(5))
            System.Console.WriteLine(m);
            MyDictionary<string, string> city = new MyDictionary<string, string>();
            city.Add("Spain", "Madrid");
            city.Add("Kuba", "Gavana");
            foreach(var m in city.GetAll(5))
            System.Console.WriteLine(m);            
            System.Console.WriteLine(city.GetElement("Kuba"));
            System.Console.WriteLine(city.Length);
        }
    }
}
