using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab4
    {
        public int CalculateVat(int belopp)
        {
            return Convert.ToInt32(belopp * 0.25m);
        }

        internal void Run()
        {
            Console.WriteLine(CalculateVat(100));
        }
    }
}
