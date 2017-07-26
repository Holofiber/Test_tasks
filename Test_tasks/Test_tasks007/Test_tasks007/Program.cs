using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_tasks007
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, l;
            Console.WriteLine("Enter your first parametr: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second parametr: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Matrix {0}*{1} : ", k,l);
            int[,] myMatrix;
            myMatrix = new int[k,l];
       
           for (int i = 0; i < k; i++)
            
                for (int j =0; j < l; j++)
                   myMatrix[i, j] = i * j;

            for (int i = 0; i < k;i++)
            {
                for (int j = 0; j < l; j++)
                   
                    Console.Write(myMatrix[i,j] + "\t");
                Console.WriteLine();
                    }
            Console.WriteLine();
            Console.ReadKey();


        }
        
    }
}
