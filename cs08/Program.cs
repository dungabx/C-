using System;
using System.Linq; // thu vien them nhieu chuc nang cho array
namespace cs08
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
            string[] ds;
            string[] ds = {phantu1,phantu2,phantu3}
            string[] ds = new string[so phan tu] {phantu1,phantu2,phantu3};
            
            */
            // string[] ds;
            // ds = new string[3];

            // ds[0] = "Nguyen Van A";
            // ds[1] = "Nguyen Van B";
            // ds[2] = "Nguyen Van C";
            // for (int i = 0; i <= ds.Length; i++)
            // {
            //     System.Console.WriteLine(ds[i]);
            // }

            int[] mangsonguyen = { 1, 3, 2, 4, 5, 6, 7, 10, 29, 102 };

            // int c = 0;
            // while (c < mangsonguyen.Length)
            // {
            //     System.Console.Write($"{mangsonguyen[c]} ");
            //     c++;
            // }

            // int a = mangsonguyen.Length; // lay ra do dai cua mang;
            // int b = mangsonguyen.Rank; // lay ra so chieu cua mang;
            // int c = mangsonguyen.Min();// lau ra gia tri phan tu nho nhat cua mang
            // int d = mangsonguyen.Max();// lau ra gia tri phan tu lon nhat cua mang
            // int e = mangsonguyen.Sum();// lau ra tong gia tri cua mang

            // Array.Sort(mangsonguyen); // sap xep cac phan tu trong mang 

            // foreach (var x in mangsonguyen)
            // {
            //     System.Console.WriteLine(x);
            // }


            int[,] mang_haichieu = new int[2, 3] { { 1, 2, 4 }, { 1, 2, 3 } };
            int hang = 2;//hang
            int cot = 3;//cot

            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    System.Console.Write(mang_haichieu[i, j]);
                    System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }


        }
    }
}