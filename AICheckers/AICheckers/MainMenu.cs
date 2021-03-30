using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AICheckers
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newGameBox_MouseDown(object sender, MouseEventArgs e)
        {
            newGameBox.Load("../../New_Game_OnClick.png");
        }

        private void newGameBox_MouseUp(object sender, MouseEventArgs e)
        {
            newGameBox.Load("../../New_Game.png");
            Board board = new Board();
            board.ShowDialog();
        }
    }
}
