using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalCheck
{
    class Program
    {
        public static int rowsSize = 5;
        public static int columnSize = 5;
        public  static int lineSize = 3;
        public  static int columnminus1 = columnSize - 1;
        static void Main(string[] args)
        {
            int tmp=0;
            bool win = false;


            int[,] ticTac = new int[columnSize, rowsSize];
            for (int i = 0; i < columnSize; i++)
            {
                System.Console.WriteLine();
                for (int j = 0; j < rowsSize; j++)
                {
                    ticTac[i, j]=tmp++ ;
                    System.Console.Write(ticTac[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //PrintDiagonal(ticTac);
            Vline(ticTac);
           
            Console.ReadLine();
        }

        public static void PrintDiagonal(int[,] matrix)
        {
            
            
            for (int i = columnminus1; i >= 0; i--)
            {
                Console.Write(matrix[i,i]+" ");
            }
            Console.WriteLine();

            for (int i = 0; i < columnSize; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < columnSize; i++)
            {
                Console.Write(matrix[i, columnminus1 -i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < columnSize; i++)
            {
                Console.Write(matrix[columnminus1- i, i] + " ");
            }
            Console.WriteLine();
        }

        public static void Vline(int[,] vmatrix)
        {
            for (int i = 0; i < columnSize/2; i++)
            {
                Console.Write(vmatrix[i,  i] + " ");
            }
            for (int i = columnSize/2; i < columnSize; i++)
            {
                Console.Write(vmatrix[ i, columnminus1 - i] + " ");
               }

            for (int i = 0; i < columnSize / 2; i++)
            {
                Console.Write(vmatrix[i, i] + " ");
            }
            for (int i = columnSize / 2; i < columnSize; i++)
            {
                Console.Write(vmatrix[columnminus1 - i, i] + " ");
            }


        }
       
    }
}
