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
            string text = "Three Forex related values";
            char separator = ' ';




            List<string> wordsList = new List<string>();

            //початковий індекс
            int start = 0;

            while (!string.IsNullOrWhiteSpace(text))
            {
                int spaseIndex = text.IndexOf(separator);

                string word;

                if (spaseIndex == -1)
                {
                    word = text;
                    text = string.Empty;
                }
                else
                {
                    word = text.Substring(start, spaseIndex);
                    text = text.Remove(start, spaseIndex + 1);
                }

                wordsList.Add(word);

            }



            // виводимо слова зі списку

            foreach (var word in wordsList)
            {
                Console.WriteLine(word);
            }


            Console.Read();
        }


    }
}
