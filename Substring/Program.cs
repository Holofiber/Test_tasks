using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "Three Forex related values in the OrdType field were deprecated and replaced in FIX 4.3 by the combined use of specifying CURRENCY in the Product field and OrdType values. These deprecated OrdType values were removed in FIX 4.4. See the individual deprecated Forex values for their mappings: ForexMarket, ForexLimit and ForexPreviouslyQuoted";
            string s = "Three Forex related values";
            char separator = ' ';




            List<string> words = new List<string>();

            //початковий індекс
            int start = 0;

            while (!string.IsNullOrWhiteSpace(s))
            {
                int spaseIndex = s.IndexOf(separator);

                if (spaseIndex == -1)
                {
                    words.Add(s);
                    break;
                }

                string text = s.Substring(start, spaseIndex);

                words.Add(text);

                s = s.Remove(start, spaseIndex + 1);
            }



            // виводимо слова зі списку

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }


            Console.Read();
        }


    }
}
