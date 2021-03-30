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
        private const string BLACK_IMAGE = "~/fakePath/black.png";
        private const string WHITE_IMAGE = "~/fakePath/white.png";
        private const string EMPTY_IMAGE = "~/fakePath/empty.png";

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

            // TODO: populate pictureBoxes.
            game = new Game();
            refreshBoxes();
        }

        private void selectSquare(int x, int y) {
            MessageBox.Show(string.Format("You just clicked ({0}, {1})!", x, y));
        }

        private void refreshBoxes() {
            for (int i = 0; i < pictureBoxes.Length; i++) {
                if (game.Current.Tiles[i] == Node.BLACK)
                    pictureBoxes[i].ImageLocation = BLACK_IMAGE;
                else if (game.Current.Tiles[i] == Node.WHITE)
                    pictureBoxes[i].ImageLocation = WHITE_IMAGE;
                else
                    pictureBoxes[i].ImageLocation = EMPTY_IMAGE;
            }
        }
    }
}
