using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AICheckers {
    public partial class Board : Form {
        private const string BLACK_IMAGE = "fakePath/Black.jpg";
        private const string WHITE_IMAGE = "fakePath/White.jpg";
        private const string EMPTY_IMAGE = "fakePath/Empty.jpg";

        private PictureBox[] pictureBoxes;
        private Game game;
        public Board() {
            InitializeComponent();
            pictureBoxes = new PictureBox[64];

            int width = 40;
            int height = 40;
            int distance = 5;
            int startX = 10;
            int startY = 10;

            for (int x = 0; x < 8; x++) {
                for (int y = 0; y < 8; y++) {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Left = startX + (x * height + distance);
                    pictureBox.Top = startY + (y * width + distance);
                    pictureBox.Width = width;
                    pictureBox.Height = height;
                    int tmpX = x;
                    int tmpY = y;
                    pictureBox.Click += (s, e) => { selectSquare(tmpX+1, tmpY+1); };

                    Controls.Add(pictureBox);
                    pictureBoxes[y * 8 + x] = pictureBox;
                }
            }

            game = new Game();
            game.AIMakeMove();
            refreshBoxes();
        }

        private int selectedX = -1;
        private int selectedY = -1;
        private void selectSquare(int x, int y) {
            if (game.Current.Tiles[(y - 1) * 8 + x - 1] != Node.WHITE) {
                MessageBox.Show("Select one of your own tiles!");
            } else {
                selectedX = x;
                selectedY = y;
            }
        }

        private void refreshBoxes() {
            for (int i = 0; i < pictureBoxes.Length; i++) {
                if (game.Current.Tiles[i] == Node.BLACK)
                    pictureBoxes[i].Load(BLACK_IMAGE);
                else if (game.Current.Tiles[i] == Node.WHITE)
                    pictureBoxes[i].Load(WHITE_IMAGE);
                else
                    pictureBoxes[i].Load(EMPTY_IMAGE);
            }
        }

        private void btnMoveNorthWest_Click(object sender, EventArgs e) {
            if (selectedX == -1 || selectedY == -1) {
                MessageBox.Show("Please select a square first!");
            } else {
                game.HumanMakeMove(selectedX, selectedY, MoveDirection.NORTH_WEST);
                game.AIMakeMove();
                refreshBoxes();
                selectedX = -1;
                selectedY = -1;
            }
        }

        private void btnMoveNorthEast_Click(object sender, EventArgs e) {
            if (selectedX == -1 || selectedY == -1) {
                MessageBox.Show("Please select a square first!");
            } else {
                game.HumanMakeMove(selectedX, selectedY, MoveDirection.NORTH_EAST);
                game.AIMakeMove();
                refreshBoxes();
                selectedX = -1;
                selectedY = -1;
            }
        }

        private void btnMoveSouthWest_Click(object sender, EventArgs e) {
            if (selectedX == -1 || selectedY == -1) {
                MessageBox.Show("Please select a square first!");
            } else {
                game.HumanMakeMove(selectedX, selectedY, MoveDirection.SOUTH_WEST);
                game.AIMakeMove();
                refreshBoxes();
                selectedX = -1;
                selectedY = -1;
            }
        }

        private void btnMoveSouthEast_Click(object sender, EventArgs e) {
            if (selectedX == -1 || selectedY == -1) {
                MessageBox.Show("Please select a square first!");
            } else {
                game.HumanMakeMove(selectedX, selectedY, MoveDirection.SOUTH_EAST);
                game.AIMakeMove();
                refreshBoxes();
                selectedX = -1;
                selectedY = -1;
            }
        }
    }
}
