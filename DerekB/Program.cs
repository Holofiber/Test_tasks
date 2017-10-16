using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekB
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(80);
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
           

            MiniVan myVan = new MiniVan();
            myVan.Speed = 10;
            Console.WriteLine("My Van going {0} MPH", myVan.Speed);

            myVan.currSpeed = 55;
            Console.ReadLine();
        }
        
       
        }
}
