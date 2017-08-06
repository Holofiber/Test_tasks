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
        static String[,] ticTac;
        static bool Player;
        static String PlayerName;

        static void Main(string[] args)
        {

            CreateGameBoard();


            ClearGameBoard();



            InitializePlayer();



            GameLoop();


            System.Console.ReadLine();

        }

        private static void GameLoop()
        {
            while (true)
            {
                //Set player name
                if (Player == true)
                    PlayerName = "X";
                else
                {
                    PlayerName = "O";
                }


                //Print board
                System.Console.WriteLine("Tic Tac Toe board");


                for (int i = 0; i < 3; i++)
                {
                    System.Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                        System.Console.Write(ticTac[i, j] + "\t");
                }

                System.Console.WriteLine();
                System.Console.WriteLine();


                //process player turn
                System.Console.WriteLine(PlayerName + "turn : ");
                string s1 = System.Console.ReadLine();
                int x1 = Convert.ToInt32(s1);


                var s2 = System.Console.ReadLine();
                int x2 = Convert.ToInt32(s2);

                //Write plaer turn in board
                ticTac[x1, x2] = PlayerName;

                //Clear screen
                System.Console.Clear();

                //change plaers turn
                Player = !Player;
            }
        }

        private static void InitializePlayer()
        {
            Player = true;

            PlayerName = "";
        }

        private static void CreateGameBoard()
        {

            ticTac = new string[3, 3];
        }

        private static void ClearGameBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    ticTac[i, j] = "*";
            }
        }
    }

}
