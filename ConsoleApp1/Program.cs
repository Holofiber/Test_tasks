using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=3, l=3;
          //  Console.WriteLine("Enter your first parametr: ");
          //  k = Convert.ToInt32(Console.ReadLine());
          //  Console.WriteLine("Enter your second parametr: ");
         //   l = Convert.ToInt32(Console.ReadLine());
          //  Console.WriteLine("Your Matrix {0}*{1} : ", k, l);
            int[,] myMatrix;
            myMatrix = new int[k, l];

           for (int i = 0; i < k; i++)

                for (int j = 0; j < l; j++)
                    myMatrix[i, j] = i * j;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)

                    Console.Write( myMatrix[i, j] + " \t");
                Console.WriteLine();
            }

            Console.WriteLine("\t╔═════╦═════╦═════╗");
            Console.WriteLine($"\t║ {myMatrix[0, 0],3} ║ {myMatrix[0, 1],3} ║ { myMatrix[0, 2],3} ║");
            Console.WriteLine("\t╠═════╬═════╬═════╣");
            Console.WriteLine($"\t║ {myMatrix[1, 0],3} ║ {myMatrix[1, 1],3} ║ { myMatrix[1, 2],3} ║");
            Console.WriteLine("\t╠═════╬═════╬═════╣");
            Console.WriteLine($"\t║ {myMatrix[2, 0],3} ║ {myMatrix[2, 1],3} ║ { myMatrix[2, 2],3} ║");
            Console.WriteLine("\t╚═════╩═════╩═════╝");

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
