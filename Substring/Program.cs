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
                int symbolsToRemove;

                if (spaseIndex == -1)
                {
                    word = text;
                    symbolsToRemove = text.Length;
                }
                else
                {
                    word = text.Substring(start, spaseIndex);
                    symbolsToRemove = spaseIndex + 1;
                }
                
                text = text.Remove(start, symbolsToRemove);


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
