using System;
namespace cs18
{
    class Abc
    {
        public void xinChao() => System.Console.WriteLine("Hello");
    }
    class Program
    {
        static void Main(String[] args)
        {
            //null, nullable
            //null - khong tham chieu den gia tri nao
            //nullable - gan gia tri null cho bien tham tri  

            Abc a = new Abc();
            if (a != null)
                a.xinChao();
            a?.xinChao();


            //nullable
            int? age;
            age = null; // int age =null {Loi}
            age = 10;
            if (age != null)
            {
                int age_ = (int)age;
                System.Console.WriteLine(age_);
            }
        }
    }
}