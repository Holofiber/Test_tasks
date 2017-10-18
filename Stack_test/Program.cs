using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack2 = new Stack<int>();
            for (int i =0; i<10; i++)
            {
                
                    stack2.Push(i);
                var k = stack2;
                             
            
            }


            Console.WriteLine("S test");
            StackTest();
            Console.WriteLine("Q test");
            QueueTest();

            Console.ReadLine();

        }

        private static void QueueTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(32);

            foreach (int vuvid in queue)
            {
                Console.WriteLine(vuvid);
            }
            Console.WriteLine("********************************");
            int save = queue.Dequeue();

            Console.WriteLine("save {0}", save);

            foreach (int vuvid in queue)
            {
                Console.WriteLine(vuvid);
            }
        }

        private static void StackTest()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(3);
            stack.Push(5);
            stack.Push(32);

            foreach (int vuvid in stack)
            {
                Console.WriteLine(vuvid);
            }
            Console.WriteLine("********************************");
            int save = stack.Pop();

            Console.WriteLine("save {0}", save);

            foreach (int vuvid in stack)
            {
                Console.WriteLine(vuvid);
            }
        }
    }
}
