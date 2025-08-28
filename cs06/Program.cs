using System;
namespace cs06
{
    class Program
    {
        static void Main(String[] args)
        {
            System.Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            // if (a == 1)
            // {
            //     System.Console.WriteLine("gia tri cua a bang mot");
            // }
            // else if (a == 2)
            // {
            //     System.Console.WriteLine("gia tri cua a bang hai");
            // }
            // else
            // {
            //     System.Console.WriteLine("hay kiem tra so khac");
            // }

            switch (a)
            {
                case 1:
                    System.Console.WriteLine("gia tri cua a bang 1");
                    break;
                case 2:
                    System.Console.WriteLine("gia tri cua a bang 2");
                    break;
                case 3:
                    System.Console.WriteLine("gia tri cua a bang 3");
                    break;
                case 4:
                    System.Console.WriteLine("gia tri cua a bang 4");
                    break;
                default:
                    System.Console.WriteLine("Hay thu so khac !");
                    break;
            }
            System.Console.WriteLine("nhap so dau tien: ");
            int c = int.Parse(Console.ReadLine());
            System.Console.WriteLine("nhap so thu hai: ");
            int d = int.Parse(Console.ReadLine());
            L1:
            System.Console.WriteLine("Hay chon lenh:");
            System.Console.WriteLine("1) tinh tong");
            System.Console.WriteLine("2) tinh hieu");
            System.Console.WriteLine("3) tinh tich");
            System.Console.WriteLine("4) tinh thuong");
            char f = Console.ReadKey().KeyChar;
            System.Console.WriteLine();
            switch (f)
            {
                case '1':
                    System.Console.WriteLine($"{c} + {d} = {c + d}");
                    break;
                case '2':
                    System.Console.WriteLine($"{c} - {d} = {c - d}");
                    break;
                case '3':
                    System.Console.WriteLine($"{c} * {d} = {c * d}");
                    break;
                case '4':
                    System.Console.WriteLine($"{c} / {d} = {c / d}");
                    break;
                default:
                    System.Console.WriteLine(" nhap lai lenh !");
                    goto L1;
                    break;
            }
            
        }
    }
}