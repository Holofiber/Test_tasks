using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MatrixSize
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int m;

            int format = InputParametrs();
            MatrixSize matrixSize = InputMatrixSize();

            int[,] myMatrix;
            myMatrix = new int[matrixSize.Rows, matrixSize.Columns];
                        
            FillMatrix(matrixSize, myMatrix);

            BuildTopOfMatrix(format, matrixSize);
            
            BuildVerticalLines(matrixSize, format, myMatrix);

            BuildLastLine(format, myMatrix, matrixSize);
            
            BuildUnderLine(format, matrixSize);
            
            Console.WriteLine();
            Console.ReadKey();


            var newString = TakeStringNtimes("═", format);

            // 5, "═" --> ══════


            Console.WriteLine(newString);
        }

        private static int InputParametrs()
        {
            int format;

            Console.WriteLine("Format");
            format = Convert.ToInt32(Console.ReadLine());

            return format;
        }

        private static MatrixSize InputMatrixSize()
        {
            MatrixSize size = new MatrixSize();

            Console.WriteLine("Enter columns: ");
            size.Columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rows: ");
            size.Rows = Convert.ToInt32(Console.ReadLine());

            return size;
        }




        private static string TakeStringNtimes(string input, int count)
        {
            string result = String.Empty;

            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }


        private static void FillMatrix(MatrixSize size, int[,] matrix)
        {

            for (int i = 0; i < size.Rows; i++)
            {
                for (int j = 0; j < size.Columns; j++)
                {
                    matrix[i, j] = i * j;
                }
            }

        }

        private static void BuildTopOfMatrix(int format, MatrixSize matrixSize)
        {
            Console.Write("╔" + TakeStringNtimes("═", format));
            for (int n = 0; n < (matrixSize.Rows - 1); n++)
            {
                Console.Write("╦" + TakeStringNtimes("═", format));
            }
            Console.Write("╗");
            Console.WriteLine();
        }
        
        private static void BuildVerticalLines(MatrixSize matrixSize,  int format, int[,] matrix)
        {
            int m;
            for (m = 0; m < (matrixSize.Columns - 1); m++)
            {
                Console.Write("║");
                for (int i = 0; i < matrixSize.Rows; i++)
                {
                    for (int j = 0; j < matrixSize.Columns; j++)
                    {
                        matrix[i, j] = i * j;
                    }
                    Console.Write($"{matrix[i, m].ToString().PadLeft(format)}" + "║");
                }

                //
                Console.WriteLine();
                Console.Write("╠" + TakeStringNtimes("═", (format / 2 + 1)));
                for (int n = 0; n < (matrixSize.Rows - 1); n++)
                {
                    Console.Write(TakeStringNtimes("═", (format / 2)) + "╬" + TakeStringNtimes("═", (format / 2 + 1)));
                }
                Console.Write(TakeStringNtimes("═", (format / 2)) + "╣");
                Console.WriteLine();
            }
        }

        private static void BuildLastLine (int format, int[,] matrix, MatrixSize matrixSize )
        {
            Console.Write("║");
            for (int i = 0; i < matrixSize.Rows; i++)
            {
                for (int j = 0; j < matrixSize.Columns; j++)
                {
                    matrix[i, j] = i * j;
                }
                Console.Write($"{matrix[i, (matrixSize.Columns - 1)].ToString().PadLeft(format)}" + "║");
            }
            Console.WriteLine();
        }

        private static void BuildUnderLine(int format, MatrixSize matrixSize)
        {
            Console.Write("╚" + TakeStringNtimes("═", format));
            for (int n = 0; n < (matrixSize.Rows - 1); n++)
            {
                Console.Write("╩" + TakeStringNtimes("═", format));
            }
            Console.Write("╝");
            Console.WriteLine();

        }

    }
}
