using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> n = new MyList<int>();
            n.Add(5);
            System.Console.WriteLine(n.list[0]);
        }
    }
}
