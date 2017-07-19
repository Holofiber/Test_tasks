using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task006
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter number
            int k = Convert.ToInt32(Console.ReadLine()); //Enter with console
            int digitCount = (int)Math.Log10(k) + 1;
            //   Console.WriteLine(digitCount);
            //int k = 123; Enter with code
            if (-1000 < k && k < 1000)
            {
                int n1 = k % 10;
                k = k / 10;
                int n2 = k % 10;
                k /= 10;
                int n3 = k % 10;
                Console.WriteLine(n2 + n1 + n3);
            }
            else
            {
                Console.WriteLine("Enter your number: from -999 to 999");
            }
        }
    }
}
