using System;

namespace Test_tasks007
{
    public class Matrix
    {
        private readonly int k;
        private readonly int l;

        public int[,] myMatrix;
        
        public Matrix(int k, int l)
        {
            this.k = k;
            this.l = l;
            this.myMatrix = new int[k, l];
        }
        

        public void Print()
        {
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    var formatedValue = myMatrix[i, j] + "\t";
                    Console.Write(formatedValue);
                }

                Console.WriteLine();
            }
        }

        public void Fill()
        {
            for (int i = 0; i < k; i++)
            for (int j = 0; j < l; j++)
                myMatrix[i, j] = i * j;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int k, l;
            ReadMatrixParameters(out k, out l);
            
            Matrix m1 = new Matrix(k, l);
            Matrix m2 = new Matrix(k+1, l+1);


            m1.Print();

            Console.WriteLine();

            m2.Print();




            //FillMatrix(k, l, myMatrix);
            
            //PrintMatrix(k, l, myMatrix);

            

            Console.WriteLine();
            Console.ReadKey();
        }

        
        private static void ReadMatrixParameters(out int k, out int l)
        {
            Console.WriteLine("Enter your first parametr: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second parametr: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Matrix {0}*{1} : ", k, l);
        }


        
    }
}
