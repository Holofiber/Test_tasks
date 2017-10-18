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
            Menu newTarif = new Menu("2: New Tarif");
            Menu currentTarif = new Menu("1: Current tarif");
            Menu currentTarifPrice = new Menu("\t1: Price per monthly");
            Menu currentTarifCountData = new Menu("\t2: Count avarege your data");
            Menu currentTarifRecomendation = new Menu("\t3: Recomendation tarif for you");
            Menu connectToOperator = new Menu("3: Connect to operator");
            Menu newTarifInternet = new Menu("\t1: Internet tarifs");
            Menu newTarifCalling = new Menu("\t2: Calling tarif");


            mainMenu.MenuItems.Add(currentTarif);
            mainMenu.MenuItems.Add(newTarif);
            mainMenu.MenuItems.Add(connectToOperator);

            currentTarif.MenuItems.Add(currentTarifPrice);
            currentTarif.MenuItems.Add(currentTarifCountData);
            currentTarif.MenuItems.Add(currentTarifRecomendation);

            newTarif.MenuItems.Add(newTarifInternet);
            newTarif.MenuItems.Add(newTarifCalling);

            newTarifInternet.MenuItems.Add(new Operation("Tarif", "\t \tSuper tarif"));
            newTarifCalling.MenuItems.Add(new Operation("Call", "\t\tFree call"));

            currentTarifPrice.MenuItems.Add(new Operation("Price", "\t\t100"));
            currentTarifCountData.MenuItems.Add(new Operation("Count Data", "\t\t1978"));
            currentTarifRecomendation.MenuItems.Add(new Operation("Recomendation", "\t\tEconom tarif"));

            connectToOperator.MenuItems.Add(new Operation("Operator", "\t\tConnect"));
            
            Menu currentMenu = mainMenu;
            Stack<Menu> stack = new Stack<Menu>();

            while (true)
            {
                Console.WriteLine("____________________________");
                
                Console.WriteLine(currentMenu.Name);

                foreach(MenuItem item in currentMenu.MenuItems)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("0: return");

                int menuNumber = Convert.ToInt32(Console.ReadLine());
                
                if (menuNumber == 0)
                {
                    if ((menuNumber == 0) && (currentMenu == mainMenu))
                    {
                        Console.WriteLine("Thank You! ");
                        Thread.Sleep(1000);

                        Environment.Exit(0);
                    }                   
                    currentMenu = stack.Pop();                                      
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
                    //  prevMenu = currentMenu;
                    stack.Push(currentMenu);

                    Menu menu = menuItem as Menu;
                    
                    currentMenu = menu;
                    
                }
            }            
        }

       

          

     
      


    }
}
