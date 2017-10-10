using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.Write("Enter first number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter four number : ");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The average : {0}", (n1 + n2 + n3 + n4) / 4);

            Console.Read();
        }
    }
}
