using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Console
{
    public class PlayerTurn
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set
            {
                if (x > 2)
                    System.Console.WriteLine("Error");
                else
                    x = value;
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (y > 2)
                    System.Console.WriteLine("Error");
                else
                    y = value;
            }
        }



    }
}
