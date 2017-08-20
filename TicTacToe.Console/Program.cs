using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TicTacToe.Libr;

namespace TicTacToe.Console
{
    class Program
    {
        private static readonly GameBoard GameBoard = new GameBoard();
        private static readonly Player Player = new Player();



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
                try
                {
                    GameBoard.PrintBoard();

                    PlayerTurn turn = ProcessPlayerTurn();

                    GameBoard.WritePlayerTutnInBoard(Player, turn);

                    var checkWin = GameBoard.CheckWin();
                    if (checkWin)
                    {

                        System.Console.WriteLine($"{Player.Name} win!");
                        break;
                    }
                    //draw
                    Player.ChangePlayerTurn();
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
            System.Console.WriteLine(Player.Name + " turn : ");
            string s1 = System.Console.ReadLine();

            int x1 = Convert.ToInt32(s1);

            var s2 = System.Console.ReadLine();
            int x2 = Convert.ToInt32(s2);

            PlayerTurn turn = new PlayerTurn
            {
                X = x1,
                Y = x2
            };
            return turn;
        }

    }
}

