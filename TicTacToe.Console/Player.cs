using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Console
{

    public class Player
    {
        public string Name { get; set; }



        private bool playerSide;

        private bool PlayerSide
        {
            get => playerSide;
            set
            {
                playerSide = value;
                SetPlayerName();
            }
        }

        public Player()
        {
            PlayerSide = true;
        }


        private void SetPlayerName()
        {
            if (PlayerSide == true)
                Name = "X";
            else
            {
                Name = "O";
            }
        }

        public void ChangePlayerTurn()
        {
            PlayerSide = !PlayerSide;
        }
    }

}
