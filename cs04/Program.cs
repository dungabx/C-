using System;
using System.IO.Pipelines;

namespace cs04
{
    class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("Hello");

            bool isOnline;
            isOnline = true;
            System.Console.WriteLine(isOnline);
            // == > < >= <= !=
            bool kq;
            int a = 5, b = 6;
            kq = a == b;
            System.Console.WriteLine("a == b ==> {0}", kq);
            System.Console.WriteLine($"a != b ==> {a != b}");
            System.Console.WriteLine($"a > b ==> {a > b}");
            System.Console.WriteLine($"a < b ==> {a < b}");
            System.Console.WriteLine($"a >= b ==> {a >= b}");
            System.Console.WriteLine($"a <= b ==> {a <= b}");

            Console.Clear();
            // && || !
            bool c = false, d = true;
            kq = !d;
            System.Console.WriteLine(kq);
            
        }
    }
}