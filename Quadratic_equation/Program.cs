using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            //Enter a
            Console.Write("Введ1ть значення a: ");
            string a1 = Console.ReadLine();
            a = Convert.ToDouble(a1);
            Console.WriteLine();

            //Enter b
            Console.Write("Введ1ть значення b: ");
            string b1 = Console.ReadLine();
            b = Convert.ToDouble(b1);
            Console.WriteLine();

            //Enter c
            Console.Write("Введ1ть значення c: ");
            string c1 = Console.ReadLine();
            c = Convert.ToDouble(c1);
            Console.WriteLine();

            d = b * b - 4 * a * c;
            Console.WriteLine("Дескрим1нант = {0}", d);

            if (d > 0)
            {
                var x1 = (-b + Math.Sqrt(d)) / (2 * a);
                ;
                Console.WriteLine($"x1={x1:F4}");

                var x2 = ((-b) - (Math.Sqrt(d))) / (2 * a);
                Console.WriteLine($"x2= {x2:F4}");

                var k = a * x1 * x1 + b * x1 + c;
                Console.WriteLine("Перев1рка\na * x1 * x1 + b * x1 + c={0:F4}", k);

                var k2 = a * x2 * x2 + b * x2 + c;
                Console.WriteLine("a * x2 * x2 + b * x2 + c={0:F4}", k2);
            }

            else if (Math.Abs(d - 3) < 0.0001)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x={0}", x);

                var k3 = a * x * x + b * x + c;
                Console.WriteLine($"Перев1рка\n a * x * x + b * x + c={k3}");
            }
            else if (d < 0)
                Console.WriteLine("Р1шення немає");


            //14, 55 23
            Console.ReadLine();
        }
    }
}
