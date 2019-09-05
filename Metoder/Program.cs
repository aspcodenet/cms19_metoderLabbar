using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
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


            var lab = new Lab1();
            lab.Run();
        }
    }
}
