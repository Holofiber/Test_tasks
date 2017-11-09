using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2, m = 1, k = 4, l = 7;

            //var list = new List<int>(){n,m,k, l, 10,99, 3, 54,6, 1,12};

            //if (n>m)
            //    Console.WriteLine(n);
            //else
            //    Console.WriteLine(m);

            //if(n>m & n>k)
            //    Console.WriteLine(n);
            //else if (m>n & m>k)
            //    Console.WriteLine(m);
            //else if (k>n & k>m)
            //    Console.WriteLine(k);
            //else
            //    Console.WriteLine(m);

            // var list2 = new List<int>();
            //list.Sort();
            //list.Reverse();
            //Console.WriteLine(list[0]);

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (list[i]>list[j])


            //    }
            //}

            ////int maxNumb=1;

            //if (n > m)
            //{
            //     maxNumb = n;
            //}
            //else
            //{
            //     maxNumb = m;
            //}

            //int g = 5;

            //if (maxNumb<g)
            //{
            //    maxNumb = g;
            //}

            //int f = 4;

            //var list = new List<int>() {  -2,  -5, -3,-1, 7, -3, 0 };

            //int maxNumb = 1;

            //for (int i = 0; i < list.Count-1; i++)
            //{
            //    if (list[i] > list[i + 1])
            //    {
            //        maxNumb = list[i];
            //    }
            //    else
            //    {
            //        maxNumb = list[list.Count-1];
            //    }
            //}



            //var list = new List<int>() { -2, -5, -3, -1, -7, -3, 0, -5, 9, -3, 1, 0, 0, 1, -5 };

            //int maxNumb = list[1];

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] > maxNumb)
            //    {
            //        maxNumb = list[i];
            //    }

            //}

            //var list = new List<int>() { -2 };
            //int maxNumb;

            //if (list.Count > 1)
            //{
            //    maxNumb = list[1];
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list[i] > maxNumb)
            //        {
            //            maxNumb = list[i];
            //        }
            //    }
            //}
            //else
            //{
            //    maxNumb = list[0];
            //}

            var list = new List<int>() { -2, 3, 6 };
            int maxNumb;


            maxNumb = list[0];
            foreach (int t in list)
            {
                if (t > maxNumb)
                {
                    maxNumb = t;
                }
            }
            list.


            Console.WriteLine(maxNumb);
            Console.ReadLine();
        }
    }
}
