using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
             a = Convert.ToInt16(Console.ReadLine());

            if (a>1 && a<100000)
                if (a%2!=0)
                {
                    Console.WriteLine("Hollywood");
                }
            else
                {
                    Console.WriteLine("Washington");
                }
            Console.ReadKey();
        }
    }
}
