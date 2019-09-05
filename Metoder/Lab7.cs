using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab7
    {
        string HittaLangstaOrdet(string []strings)
        {
            string longestSoFar = "";
            foreach(var ord in strings)
            {
                if (ord.Length > longestSoFar.Length)
                    longestSoFar = ord;
            }
            return longestSoFar;
        }
        internal void Run()
        {
            string[] ord = new []{"das","243243243","mldjkldajkldjdklas"};
            string s = HittaLangstaOrdet(ord);
            Console.WriteLine(s);
        }
    }
}
