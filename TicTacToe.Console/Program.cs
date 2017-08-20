using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe.Console
{
    class Program
    {

        static GameBoard gameBoard = new GameBoard();
        static Player player = new Player();
        static PlayerTurn playerTurn = new PlayerTurn();
        
        
        static void Main(string[] args)
        {
            GameLoop();

            System.Console.WriteLine("Game Over");
            System.Console.ReadLine();
        }

        private static void GameLoop()
        {
            while (true)
            {

                

               gameBoard.PrintBoard();

                


                PlayerTurn turn = ProcessPlayerTurn();


                try
                {
                    gameBoard.WritePlayerTutnInBoard(player, turn);


                    var checkWin = gameBoard.CheckWin();
                    if (checkWin)
                    {

                        System.Console.WriteLine($"{player.Name} win!");
                        break;
                    }


                    player.ChangePlayerTurn();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }

                ClearScreen();
            }

        }

        

        private static void ClearScreen()
        {
            System.Console.Clear();
        }




        public static PlayerTurn ProcessPlayerTurn()
        {
            System.Console.WriteLine(player.Name + " turn : ");
            string s1 = System.Console.ReadLine();

            int x1 = Convert.ToInt32(s1);

            var s2 = System.Console.ReadLine();
           int x2 = Convert.ToInt32(s2);

            PlayerTurn turn = new PlayerTurn();
            turn.X = x1;
            turn.Y = x2;
            return turn;



        }










    }
}

