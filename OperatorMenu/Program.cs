using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace OperatorMenu
{

    class Program
    {
        public static int currentPosition=0;

        static void Main(string[] args)
        {
            // initialize menus
            Menu mainMenu = new Menu("Main menu");
            Menu newTarif = new Menu("new Tarif");
            Menu currentTarif = new Menu(" Current tarif");
            Menu currentTarifPrice = new Menu("Count data");
            Menu currentTarifCountData = new Menu("recomendation");
            Menu currentTarifRecomendation = new Menu("Price your tarif");
            Menu connectToOperator = new Menu("Connect to operator");
            Menu newTarifInternet = new Menu("Internet tarifs");
            Menu newTarifCalling = new Menu("Calling tarif");


            mainMenu.MenuItems.Add(currentTarif);
            mainMenu.MenuItems.Add(newTarif);
            mainMenu.MenuItems.Add(connectToOperator);

            currentTarif.MenuItems.Add(currentTarifPrice);
            currentTarif.MenuItems.Add(currentTarifCountData);
            currentTarif.MenuItems.Add(currentTarifRecomendation);

            newTarif.MenuItems.Add(newTarifInternet);
            newTarif.MenuItems.Add(newTarifCalling);

            newTarifInternet.MenuItems.Add(new Operation("Tarif", "Super tarif"));
            newTarifCalling.MenuItems.Add(new Operation("Call", "Free call"));

            currentTarifPrice.MenuItems.Add(new Operation("Price","100"));
            currentTarifCountData.MenuItems.Add(new Operation("Count Data", "1978"));
            currentTarifRecomendation.MenuItems.Add(new Operation("Recomendation", "Econom tarif"));

            connectToOperator.MenuItems.Add(new Operation("Operator", "Connect"));


            //--------------------------------------
            Stack<Menu> menuStack = new Stack<Menu>();

            Menu prevMenu = null;
            Menu currentMenu = mainMenu;

            while(true)
            {
                Console.WriteLine("____________________________");
                // print info about menu
                Console.WriteLine(currentMenu.Name);

                foreach(MenuItem item in currentMenu.MenuItems)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("0: return");

                

                // enter menu item number
                int menuNumber = Convert.ToInt32(Console.ReadLine());


                if (menuNumber == 0)
                {
                    currentMenu = prevMenu;

                    if (currentMenu == null)
                    {
                        break;
                    }
                    
                }

                MenuItem menuItem;
                try
                {
                    menuItem = currentMenu.MenuItems[menuNumber - 1];
                }
                catch (Exception e)
                {
                    continue;
                }


                if (menuItem is Operation)
                {
                    Operation operation = menuItem as Operation;
                    Console.WriteLine(operation.Text);
                }
                else
                {
                    prevMenu = currentMenu; 
                    Menu menu = menuItem as Menu;
                    
                    currentMenu = menu;
                }
            }


            Console.WriteLine("THE END");
            Console.ReadLine();



            //Console.Write("Please enter your number: ");
            //int clientNumber = Convert.ToInt32(Console.ReadLine());


            ////int currentPosition=0;

            //if ((currentPosition + clientNumber) == 0)
            //{
            //    Environment.Exit(0);
            //}
            //else
            //{
            //    if (clientNumber > 0)
            //    {
            //        currentPosition = +clientNumber;
            //    }
            //    else
            //    {
            //        currentPosition = -clientNumber;
            //    }
            //}

            //Menu(clientNumber, mainMenu);




            //Console.ReadLine();
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
