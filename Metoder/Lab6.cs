using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab6
    {
        int Maxvarde2(int tal1, int tal2)
        {
            if (tal1 > tal2) return tal1;
            return tal2;
        }
        int Maxvarde3(int tal1, int tal2, int tal3)
        {
            if (tal1 > tal2 && tal1 > tal3) return tal1;
            if (tal2 > tal1 && tal2 > tal3) return tal2;
            return tal3;
        }

        int KontrolleraMaxvarde(int tal1, int tal2, int tal3)
        {
            if (tal1 == 0) return Maxvarde2(tal2, tal3);
            else if (tal2 == 0) return Maxvarde2(tal1, tal3);
            else if (tal3 == 0) return Maxvarde2(tal1, tal2);
            return Maxvarde3(tal1,tal2,tal3);
        }

        public void Run()
        {
            int max = KontrolleraMaxvarde(19,2,4);
            Console.WriteLine(max);
        }


    }
}
