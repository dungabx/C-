using System;
namespace cs16
{
    class Program
    {
        static void Swap<T>(ref T x, ref T y)
        {
            T t;
            t = x;
            x = y;
            y = t;
        }

        class Product<T>
        {
            T ID;
            public void SetID(T id)
            {
                this.ID = id;
            }

            public void PrinInf()
            {
                System.Console.WriteLine($"ID = {this.ID}");
            }
        }
        static void Main(String[] args)
        {
            int a = 5;
            int b = 45;

            System.Console.WriteLine($"So a hien tai: {a}, so b hien tai: {b}");
            Swap<int>(ref a, ref b);
            System.Console.WriteLine($"Sau khi swap so a = {a}, so b = {b} ");

            string x = "Abc";
            string y = "xyz";

            System.Console.WriteLine($"x = {x}, y = {y}");
            Swap<string>(ref x, ref y);
            System.Console.WriteLine($"x = {x}, y = {y}");

            Product<String> h = new Product<string>();
            h.SetID("0333444555");
            h.PrinInf();

            Product<int> f = new Product<int>();
            f.SetID(03456789);
            f.PrinInf();

        }
    }
}