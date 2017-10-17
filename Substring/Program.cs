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
            var text = EnterInputText();
            var separator = EnterSeparator();

            List<string> wordsList = SeparateWords(text, separator);

            PrintWords(wordsList);


            Console.Read();
        }


        public static string EnterInputText()
        {
            //string s = "Three Forex related values in the OrdType field were deprecated and replaced in FIX 4.3 by the combined use of specifying CURRENCY in the Product field and OrdType values. These deprecated OrdType values were removed in FIX 4.4. See the individual deprecated Forex values for their mappings: ForexMarket, ForexLimit and ForexPreviouslyQuoted";

            string text = "Three Forex related values";
            return text;
        }

        public static string EnterSeparator()
        {
            string separator = " ";
            return separator;
        }

        public static List<string> SeparateWords(string text, string separator)
        {

            List<string> wordsList = new List<string>();

            //початковий індекс
            int start = 0;

            while (!string.IsNullOrWhiteSpace(text))
            {
                int spaseIndex = text.IndexOf(separator);

                string word;
                int symbolsToRemove;

                bool isSpaceFound = spaseIndex >= 0;

                if (isSpaceFound)
                {
                    word = text.Substring(start, spaseIndex);
                    symbolsToRemove = spaseIndex + 1;
                }
                else
                {
                    word = text;
                    symbolsToRemove = text.Length;
                }

                text = text.Remove(start, symbolsToRemove);


                wordsList.Add(word);

            }

            return wordsList;
        }

        public static void PrintWords(List<string> words)
        {
            words.Reverse();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

        }

    }
}
