using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {

        class Dog
        {
            public string Namn;
            public void Sound()
            {
                Console.WriteLine("Voff jag heter {Namn}");
            }
            static public bool IsAnimal()
            {
                return true;
            }
        }

        class Hus
        {
            public string FasadColor;
            public int AntalRum;
            public bool HasBeenRepainted;

            public void Repaint(string newColor)
            {
                FasadColor = newColor;
                HasBeenRepainted = true;
            }
        }

        static void Main(string[] args)
        {
            var lab = new Lab1();
            lab.Run();

            var l2 = new Lab2();
            l2.ToPercentage(0.12m);

            var mittHus = new Hus();
            mittHus.AntalRum = 3;
            mittHus.FasadColor = "Blue";

            var syrransHus = new Hus();
            syrransHus.AntalRum = 5;
            syrransHus.FasadColor = "Red";

            mittHus.Repaint("Green");


            var dog1 = new Dog();
            dog1.Namn = "Karo";
            Console.WriteLine(Dog.IsAnimal());

            var dog2 = new Dog();
            dog2.Namn = "Pluto";






            var labben = new Lab10();
            labben.Run();



            var lab9 = new Lab9();
            lab9.Run();


            var lab8 = new Lab8();
            lab8.Run();

            var lab7 = new Lab7();
            lab7.Run();

            var lab6 = new Lab6();
            lab6.Run();



            var lab3 = new Lab3();
            string result = lab3.PlussaStringar("hej", "heopp");

            var lab2 = new Lab2();

            decimal input = Convert.ToDecimal(Console.ReadLine());
            int d = lab2.ToPercentage(input);

            var lab4 = new Lab4();
            lab4.Run();



            var lab5 = new Lab5();
            lab5.Run();


        }
    }
}
