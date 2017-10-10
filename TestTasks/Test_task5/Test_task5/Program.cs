using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            k = Convert.ToInt32(Console.ReadLine());
            while (k <= 0)
                k += 10;
            while (k > 10)
                k -= 10;
            Console.WriteLine(k);
        }
    }
}
