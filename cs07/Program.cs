using System;

namespace cs07
{
    class Program
    {
        static void Main(String[] args)
        {
            /* 
                for(Khoi_tao; dieu_kien; cap_nhat)
                {
                    // cac cau lenh trong khoi
                }
            */
            int i;

            for (i = 1, Console.WriteLine("khoi tao"); i < 11; i++, System.Console.WriteLine("Cap nhat"))
            {
                System.Console.WriteLine($"i = {i}");
                System.Console.WriteLine("Hello World!");
            }
            i = 1;
            // for (; i < 11;)
            // {
            //     System.Console.WriteLine($"3 * {i} = {3 * i}");
            //     i++;
            // }

            // while (i <= 10)
            // {
            //     System.Console.WriteLine($"8 * {i} = {i * 8}");
            //     i++;
            // }
            System.Console.WriteLine();
            do
            {
                System.Console.WriteLine("hello World");
                i++;
            }

            while (i <= 10);

            //break ; continue;
            // i = 0;
            // while (i < 1000)
            // {
            //     System.Console.WriteLine(i);
            //     i++;
            //     if (i == 11)
            //         break;
            // }

            for (i = 0; i <= 20; i++)
            {
                if(i%2!=0)
                    continue;
                System.Console.WriteLine(i);
            }

        }
    }
}