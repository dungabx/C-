using System;
using System.Threading.Tasks.Dataflow;

namespace cs04
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
                if (dieu_kien_logic)
                    dong_lenh;
                if (dieu_kien_logic)
                {
                    ...
                }
                else if (dieu_kien_1)
                {
                    ... khoi lenh e
                }
                else if (dieu_kien_2)
                {
                    ... khoi lenh e
                }
                else
                {
                    ...
                }
            */

            // int a;
            // Console.WriteLine("Nhap so nguyen a");
            // a = int.Parse(Console.ReadLine());
            // if (a % 2 == 0)
            // {
            //     Console.WriteLine($"So {a} la so chan");
            // }
            // else
            // {
            //     Console.WriteLine($"So {a} la so le");   
            // }

            // float dtb;
            // System.Console.WriteLine("Nhap diem trung binh:");
            // dtb = float.Parse(Console.ReadLine());
            // if (dtb >= 8 && dtb <= 10)
            // {
            //     System.Console.WriteLine("Xep loai gioi");
            // }
            // else if (dtb >= 6.5)
            // {
            //     System.Console.WriteLine("Xep loai kha");
            // }
            // else if (dtb >= 5)
            // {
            //     System.Console.WriteLine("Xep loai trung binh");
            // }
            // else
            // {
            //     System.Console.WriteLine("Xep loai yeu");
            // }

            float a, b;
            System.Console.WriteLine("nhap a");
            a = float.Parse(Console.ReadLine());
            System.Console.WriteLine("nhap b");
            b = float.Parse(Console.ReadLine());
            float max;
            // if (a > b)
            //     max = a;
            // else
            //     max = b;


            // (dieu_kien) ? bieu_thuc_1 : bieu_thuc_2;
            max = (a > b) ? a : b;
            Console.WriteLine("So lon nhat la : {0}", max);

            Console.Clear();

            float d = 0, f = 2, i = 4;
            // if (d > f)
            // {
            //     if (d > i)
            //         max = d;
            //     else
            //         max = i;
            // }
            // else
            // {
            //     if (f > i)
            //         max = f;
            //     else
            //         max = i;
            // }

            max = (d > f) ? (d > i) ? d : i : (f > i) ? f : i ;
            System.Console.WriteLine(max);
        }
    }
}