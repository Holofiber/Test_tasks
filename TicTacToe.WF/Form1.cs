using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Libr;

namespace TicTacToe.WF
{
    public partial class Form1 : Form
    {
        GameBoard gameBoard = new GameBoard();
        Player player = new Player();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTurn_Click(object sender, EventArgs e)
        {
            string s1 = tbX.Text;

            int x1 = Convert.ToInt32(s1);

            var s2 = tbY.Text;
            int x2 = Convert.ToInt32(s2);

            PlayerTurn turn = new PlayerTurn
            {
                X = x1,
                Y = x2
            };

            
            
           gameBoard.WritePlayerTutnInBoard(player, turn);

            var checkWin = gameBoard.CheckWin();
            if (checkWin)
            {

                MessageBox.Show($"{ player.Name} win!"); 
               
            }
            //draw
            player.ChangePlayerTurn();

            ShowGameBoard();
        }


        private void ShowGameBoard()
        {
            var ticTacData = gameBoard.TicTacData;
            btn00.Text = ticTacData[0, 0];
            btn01.Text = ticTacData[0, 1];
            btn02.Text = ticTacData[0, 2];
            btn10.Text = ticTacData[1, 0];
            btn11.Text = ticTacData[1, 1];
            btn12.Text = ticTacData[1, 2];
            btn20.Text = ticTacData[2, 0];
            btn21.Text = ticTacData[2, 1];
            btn22.Text = ticTacData[2, 2];
        }



    }
}
