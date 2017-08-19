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

                SetPlayerName();

                PrintBoard();

                


                int x1;
                int x2;
                ProcessPlayerTurn(out x1, out x2);


                try
                {
                    WritePlayerTutnInBoard(x1, x2);


                    CheckWin();


                    ChangePlayerTurn();
                }
                catch (Exception e)
                {
                }

                ClearScreen();
            }

        }

        private static void ChangePlayerTurn()
        {
            Player = !Player;
        }

        private static void ClearScreen()
        {
            System.Console.Clear();
        }

        private static void WritePlayerTutnInBoard(int x1, int x2)
        {



            if (x1 < 3 && x2 < 3)
                ticTac[x1, x2] = PlayerName;
            else
            {
                throw new Exception("Invalid Input data");
            }



        }

        private static void ProcessPlayerTurn(out int x1, out int x2)
        {
            System.Console.WriteLine(PlayerName + " turn : ");
            string s1 = System.Console.ReadLine();

            x1 = Convert.ToInt32(s1);

            var s2 = System.Console.ReadLine();
            x2 = Convert.ToInt32(s2);



        }

        private static void PrintBoard()
        {
            System.Console.WriteLine("Tic Tac Toe board");


            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine();
                for (int j = 0; j < 3; j++)
                    System.Console.Write(ticTac[i, j] + "\t");
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
        }

        private static void SetPlayerName()
        {
            if (Player == true)
                PlayerName = "X";
            else
            {
                PlayerName = "O";
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
        private static void CheckWin()
        {
            
            {
                bool CheckWinner = false;

                //Horiz
                if (ticTac[1, 0] != "*")
                {
                    if ((ticTac[0, 0] == ticTac[0, 1]) && (ticTac[0, 1] == ticTac[0, 2]))
                        CheckWinner = (true);
                }

                else if (ticTac[1, 0] != "*")
                {
                    if ((ticTac[1, 0] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[1, 2]))
                        CheckWinner = (true);
                }
                else if (ticTac[2, 0] != "*")
                {
                    if ((ticTac[2, 0] == ticTac[2, 1]) && (ticTac[2, 1] == ticTac[2, 2]))
                        CheckWinner = (true);
                }

                //vertical
                if (ticTac[0, 0] != "*")
                {
                    if ((ticTac[0, 0] == ticTac[1, 0]) && (ticTac[1, 0] == ticTac[2, 0]))
                        CheckWinner = (true);
                }

                else if (ticTac[1, 1] != "*")
                {
                    if ((ticTac[0, 1] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[2, 1]))
                        CheckWinner = (true);
                }
                else if (ticTac[1, 2] != "*")
                {
                    if ((ticTac[0, 2] == ticTac[1, 2]) && (ticTac[1, 2] == ticTac[2, 2]))
                        CheckWinner = (true);
                }
                //diagonal
                if (ticTac[0, 0] != "*")
                {
                    if ((ticTac[0, 0] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[2, 2]))
                        CheckWinner = (true);
                }

                else if (ticTac[1, 1] != "*")
                {
                    if ((ticTac[0, 2] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[2, 0]))
                        CheckWinner = (true);
                }

                if (CheckWinner)
                {

                    System.Console.WriteLine($"{PlayerName} win!");
                    System.Console.ReadLine();
                    

                }
            }
        }
    }
}

