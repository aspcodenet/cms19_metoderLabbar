using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab11
    {
        
        void Run()
        {
            int n = 1;
            int m = 2;

            Method(out n, ref n);
        }

        private void Method(out int n1, ref int n2)
        {
            n1 = 231231;
        }
    }
}
