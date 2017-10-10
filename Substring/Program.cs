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
            string s = "Three Forex related values in the OrdType field were deprecated and replaced in FIX 4.3 by the combined use of specifying CURRENCY in the Product field and OrdType values. These deprecated OrdType values were removed in FIX 4.4. See the individual deprecated Forex values for their mappings: ForexMarket, ForexLimit and ForexPreviouslyQuoted";
            char k = ' ';

            //Рахуємо кількісь пробілів
            int numberOfSpase = s.Split(' ').Length;
            int gf = s.Count((c) => c == ' ');
          //початковий індекс
            int start = 0;


            //for (int i = 0; i < numberOfSpase-1; i++)
            //{

            //        //індекс завершення слова
            //        int endIndex = s.IndexOf(k);

            //        //додаємо в text значення яке ми знайшли
            //        string text = s.Substring(start, endIndex);

            //        //виводимо його на екран
            //        Console.WriteLine(text);

            //        //видаляємо додану частину з пошуку
            //        s = s.Remove(start, endIndex + 1);



            //}
            //  Console.WriteLine(s);




            

            while (((s.IndexOf(k))> 0))
            {
                int SpaseIndex = s.IndexOf(k);
                string text = s.Substring(start, SpaseIndex);
                Console.WriteLine(text);
               s = s.Remove(start, SpaseIndex+1 );
            }
            
            
            


            Console.Read();
        }

        
    }
}
