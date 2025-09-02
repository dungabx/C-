using System;
namespace cs13
{
    class Program
    {
        static void Main(String[] args)
        {
            //Pi,E
            System.Console.WriteLine($"Hang so Pi {Math.PI}");
            System.Console.WriteLine($"Hang so E {Math.E}");

            //Max,Min
            System.Console.WriteLine($"Max {Math.Max(5, 6)}");
            System.Console.WriteLine($"Min {Math.Min(5, 6)}");

            double a = 0.12;
            double b = 1.2;
            double c = 2.34;

            System.Console.WriteLine(Math.Max(Math.Max(a, b), c));

            //gia tri tuyet doi
            System.Console.WriteLine(Math.Abs(-23));

            //ham luong giac 
            System.Console.WriteLine(Math.Sin(Math.PI / 2));
            double deg = 60;
            double rad = Math.PI * deg / 180;
            System.Console.WriteLine(Math.Sign(rad));

            // for (int i = 0; i <= 360; i++)
            // {
            //     rad = Math.PI * i / 180;
            //     System.Console.WriteLine($"goc {i} co sin bang {Math.Sin(rad)}");
            // }

            //Sqrt(),Pow(),Log(), Log10();
            System.Console.WriteLine(Math.Sqrt(2));
            System.Console.WriteLine(Math.Pow(2, 3));
            System.Console.WriteLine(Math.Log(5));
            System.Console.WriteLine(Math.Log10(10));

            // lam tron
            // Math.Round(a) ; 5.6 => 6 ; 5.4 => 5
            // Math.Ceiling(a); 5.1, 5.5, 5.7 => 6
            // Math.Floor(a) ; 5.1, 5.5, 5.7 => 5

            // Math.Truncate(a) : cat di phan thap phan cua con so 


        }
    }
}