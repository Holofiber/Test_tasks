using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task003
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter first number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            z = Convert.ToInt32(Console.ReadLine());
            int result1 = (x + y) * z, result2 = x * y + y * z;
            Console.Write("Result of specified numbers {0} , {1} and {2} , (x+y)*z is {3} and x*y+y*z is {4}", x, y, z, result1, result2);
            Console.Read();
        }
    }
}
