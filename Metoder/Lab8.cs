using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab8
    {
        int Sum(int []tal)
        {
            int summa = 0;
            foreach (var t in tal)
                summa += t;
            return summa;
        }

        int Multiply(int[] tal)
        {
            if (tal.Length == 0) return 0;
            int summa = 1;
            foreach (var t in tal)
                summa *= t;
            return summa;
        }

        public void Run()
        {
            var tal = new[] {1,2,3,4 };

            Console.WriteLine(Sum(tal));
            Console.WriteLine(Multiply(tal));
        }
    }
}
