using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separate_int_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string yournumber = Console.ReadLine();
   
           int number = Convert.ToInt32(yournumber);

            while ((number) > 0)
            {

                int n1 = number % 10;
                number = number / 10;
                Console.Write(n1 + " ");
                n1 = number;


            }

            //int i;
            //while ((number) > 0)
            //{
            //    int n1 = number % 10;
            //    for (i = 0; i < 5; i++)
            //    {
            //        int[] array = new int[n1];
            //    }
            //    number = number / 10;



            //}

            Console.ReadKey();


        }
        
    }
}
