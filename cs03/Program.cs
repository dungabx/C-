using System;
using System.Security.Cryptography.X509Certificates;

namespace cs03
{
    class Program
    {
        public static void Main(String[] args)
        {
            // + - * / %
            float a = 5;
            int b = 4;

            System.Console.WriteLine("a + b = {0}", a + b);
            System.Console.WriteLine("a - b = {0}", a - b);
            System.Console.WriteLine("a * b = {0}", a * b);
            System.Console.WriteLine("a / b = {0}", a / b);
            System.Console.WriteLine("a % b = {0}", a % b);

            float kq = 6 / (2 + 3) * 4;
            System.Console.WriteLine(kq);

            // Gan 
            // = += -= *= /= %=
            int x = 10;
            //x %= 2;
            System.Console.WriteLine(x);

            int z = 2 * ++x;
            System.Console.WriteLine(x);
            System.Console.WriteLine(z);
        }
    }
}