using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab9
    {
        char[] vokaler = {'a','o','u','å','e','i','å','ä','ö' };
        bool IsVokal(char ch)
        {
            char low = char.ToLower(ch);
            return vokaler.Contains(low);
        }
        public void Run()
        {
            string s = "hejsan HOPPSAN";
            foreach(char ch in s)
            {
                Console.WriteLine($"{ch}   vokal:{IsVokal(ch)}");
            }
        }
    }
}
