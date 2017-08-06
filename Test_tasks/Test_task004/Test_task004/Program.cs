using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task004
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine();
            ShowEnvironmentDetails();
            Console.ReadLine;
        }
        static void ShowEnvironmentDetails ()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine(drive);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.ProcessorCount);
            Console.WriteLine(Environment.Version);
            
             
           
        }
    }
}
