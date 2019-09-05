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

        void Translate(string sIn, ref string sOut)
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

        void TranslateAgain(ref string sIn)
        {
            var builder = new StringBuilder();
            foreach (char ch in sIn)
            {
                if (IsKonsonant(ch))
                {
                    builder.Append(ch);
                    builder.Append('o');
                    builder.Append(ch);
                }
                else builder.Append(ch);

            }
            sIn = builder.ToString();
        }




        string BetterTranslate(string sIn)
        {
            var builder = new StringBuilder();
            foreach (char ch in sIn)
            {
                if (IsKonsonant(ch))
                {
                    builder.Append(ch);
                    builder.Append('o');
                    builder.Append(ch);
                }
                else builder.Append(ch);

            }
            return builder.ToString();
        }

        class ParseResult
        {
            public int ConvertedData;
            public bool ConvertedOk;
        }
        ParseResult MyTryParse(string data)
        {
            var result = new ParseResult();
            result.ConvertedOk = Int32.TryParse(data, out result.ConvertedData);
            return result;
        }

        public void Run()
        {

            //int data;
            //bool ok = int.TryParse("231321231312", out data);
            var result = MyTryParse("3211321");
            if(result.ConvertedOk)
            {
                Console.WriteLine(result.ConvertedData);
            }

            string s = "this is fun";

            Console.WriteLine(BetterTranslate(s));

            string result1 = "";
            Translate(s, ref result1);
            TranslateAgain(ref s);
            Console.WriteLine(result1);
        }
    }
}
