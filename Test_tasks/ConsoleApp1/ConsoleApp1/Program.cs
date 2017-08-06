using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SomeVeryLongNameClass<T, U>
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            // 1) enter number
            int n;
            Console.WriteLine("Enter your number : ");
            n = Convert.ToInt32(Console.ReadLine());

            
            // 2) move number into range
            var i = n;
        
                for ( ; n < 0 && n>10; n = n + 10; )
            {
                Console.WriteLine("{0}", n);
            }

            Console.ReadKey();


            // 3) print result



        }
    }
}
