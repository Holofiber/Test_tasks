using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace OperatorMenu
{
    public class Position 
    {
        public int currentPosition;
    }
    class Program
    {
        public int currentPosition=0;

        static void Main(string[] args)


        {

            Console.WriteLine("Menu");
            //List<string> mainMenu = new List<string>(new string[] { "1. Current tarif", "2. New tarif", "3. Connect to operator", "0. Exit" });
            //List<string> currentTarif = new List<string>(new string[] { "1. Price", "2. Your Bonus", "3. Recomendation for you", "0. Back" });
            //List<string> newTarif = new List<string>(new string[] { "1. Internet", "2. Calling", "3. Back" });
            //List<string> newTrifInternet = new List<string>(new string[] { "1. Lite", "2. Standart", "3. Mega", "0. Back" });
            //List<string> newTrifCalling = new List<string>(new string[] { "1. All", "0. Back" });
            //List<string> connectToOperator = new List<string>(new string[] { "1. Connect to Operator", "0. Back" });

            List<string> mainMenu = new List<string>(new string[] { "1. Current tarif  \n2. New tarif \n3. Connect to operator \n0. Exit",
           "1. Price \n2. Your Bonus \n3. Recomendation for you \n0. Back", "1. Internet \n2. Calling \n0. Back", "1. Lite \n2. Standart \n3. Mega \n0. Back", "1. All \n0. Back", "1. Connect to Operator \n0. Back"  });





            Console.Write("Please enter your number: ");
            int clientNumber = Convert.ToInt32(Console.ReadLine());


            int currentPosition=0;

            if ((currentPosition + clientNumber) == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                if (clientNumber > 0)
                {
                    currentPosition = +clientNumber;
                }
                else
                {
                    currentPosition = -clientNumber;
                }
            }

            Menu(clientNumber, mainMenu);
            
            


            Console.ReadLine();
        }

        public static void Menu(int clientNumber, List<string> Lists)
        {
            switch (clientNumber)
            {
                case 1:
                    Console.WriteLine(Lists[0]);
                    break;
                case 2:
                    Console.WriteLine(Lists[1]);
                    break;
                case 3:
                    Console.WriteLine(Lists[2]);
                    break;
                case 4:
                    Console.WriteLine(Lists[3]);
                    break;
                case 5:
                    Console.WriteLine(Lists[4]);
                    break;
                case 6:
                    Console.WriteLine(Lists[5]);
                    break;
                case 0:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;

            }

        }

     
      


    }
}
