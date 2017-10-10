using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_tasks001
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int i, n1;
          //  Console.Write("Enter your number : ");
          //  n1 = Convert.ToInt32(Console.ReadLine());
            for (n1=1; n1<11; n1++)
            for (i = 0; i <= 10; i++)
                Console.WriteLine("          {0} * {1} = {2} ", n1, i, n1 * i);
         
            Console.Read();
        }
    }
}
