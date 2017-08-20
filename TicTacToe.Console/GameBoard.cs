﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Console
{
    public class GameBoard
    {
        private readonly string[,] ticTac;

        public GameBoard()
        {
            ticTac = new string[3, 3];
            ClearGameBoard();
        }



        public void ClearGameBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)

                    ticTac[i, j] = "*";
            }
        }

        public void PrintBoard()
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

        public void WritePlayerTutnInBoard(Player player, PlayerTurn turn)
        {
            ticTac[turn.X, turn.Y] = player.Name;
        }

        public bool CheckWin()
        {

            {
                var checkWinner = false;

                //Horiz
                if (ticTac[1, 0] != "*")
                {
                    if ((ticTac[0, 0] == ticTac[0, 1]) && (ticTac[0, 1] == ticTac[0, 2]))
                        checkWinner = (true);
                }

                else if (ticTac[1, 0] != "*")
                {
                    if ((ticTac[1, 0] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[1, 2]))
                        checkWinner = (true);
                }
                else if (ticTac[2, 0] != "*")
                {
                    if ((ticTac[2, 0] == ticTac[2, 1]) && (ticTac[2, 1] == ticTac[2, 2]))
                        checkWinner = (true);
                }

                //vertical
                if (ticTac[0, 0] != "*")
                {
                    if ((ticTac[0, 0] == ticTac[1, 0]) && (ticTac[1, 0] == ticTac[2, 0]))
                        checkWinner = (true);
                }

                else if (ticTac[1, 1] != "*")
                {
                    if ((ticTac[0, 1] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[2, 1]))
                        checkWinner = (true);
                }
                else if (ticTac[1, 2] != "*")
                {
                    if ((ticTac[0, 2] == ticTac[1, 2]) && (ticTac[1, 2] == ticTac[2, 2]))
                        checkWinner = (true);
                }
                //diagonal
                if (ticTac[0, 0] != "*")
                {
                    if ((ticTac[0, 0] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[2, 2]))
                        checkWinner = (true);
                }

                else if (ticTac[1, 1] != "*")
                {
                    if ((ticTac[0, 2] == ticTac[1, 1]) && (ticTac[1, 1] == ticTac[2, 0]))
                        checkWinner = (true);
                }
                return checkWinner;

            }
        }
    }
}
