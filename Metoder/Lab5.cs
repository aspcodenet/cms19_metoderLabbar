using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab5
    {
        bool IsMyndig(int age)
        {
            return age >= 18;
        }

        internal void Run()
        {
            Console.WriteLine("Hur många år är du");
            int age = Convert.ToInt32(Console.ReadLine());
            if (IsMyndig(age))
                Console.WriteLine("Du är myndig");
            else
                Console.WriteLine("Du är inte myndig");
        }
    }
}
