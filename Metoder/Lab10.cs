using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Lab10
    {
        char[] vokaler = { 'a', 'o', 'u', 'å', 'e', 'i', 'å', 'ä', 'ö' };
        bool IsVokal(char ch)
        {
            char low = char.ToLower(ch);
            return vokaler.Contains(low);
        }

        bool IsKonsonant(char ch)
        {
            if (Char.IsLetter(ch) && !IsVokal(ch)) return true;
            return false;
        }

        void Translate(string sIn, out string sOut)
        {
            var builder = new StringBuilder();
            foreach(char ch in sIn)
            {
                if (IsKonsonant(ch))
                {
                    builder.Append(ch);
                    builder.Append('o');
                    builder.Append(ch);
                }
                else builder.Append(ch);

            }
            sOut = builder.ToString();
        }
        public void Run()
        {
            string s = "this is fun";
            string result;
            Translate(s, out result);
            Console.WriteLine(result);
        }
    }
}
