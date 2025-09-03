using System;
namespace cs14;

class Program
{
    /*
            Tinh ke thua
            A, B
            B ke thua A 
            A - co so, cha
            B - ke thua, con

            class B : A
            {

            }   

            Animal
             -  Legs
             -  Weight
             -  ShowLegs()
            Cat : Animal

        
        */

    class Animal //sealed class : la niem phong class do va khong cho bat ki class nao ke thua
    {
        public int Legs { get; set; }
        public double Weight { get; set; }

        public Animal()
        {
            System.Console.WriteLine("Khoi tao Animal");
        }

        public Animal(int Legs, double Weight)
        {
            this.Legs = Legs;
            this.Weight = Weight;
        }

        public void ShowLegs()
        {
            System.Console.WriteLine($"Co {this.Legs} chan");
        }
    }

    class Cat : Animal
    {
        public string Food;

        public Cat()
        {
            System.Console.WriteLine("Khoi tao Cat");
        }

        public new void ShowLegs()
        {
            System.Console.WriteLine($"Meo co {this.Legs} chan");
        }
        public Cat(int Legs, double Weight)
        {
            this.Legs = Legs;
            this.Weight = Weight;
        }
        public void Eat()
        {
            System.Console.WriteLine(Food);
        }

        public void showInfo()
        {
            base.ShowLegs();
            ShowLegs();
            
        }
    }
    static void Main(string[] args)
    {
        // Cat c = new Cat();
        // c.Legs = 4;

        // c.Food = "mouse";
        // c.Eat();

        // c.showInfo();

       
    }
}