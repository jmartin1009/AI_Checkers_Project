
namespace AICheckers
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newGameBox = new System.Windows.Forms.PictureBox();
            this.difficultyBox = new System.Windows.Forms.PictureBox();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.githubBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newGameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameBox
            // 
            this.newGameBox.Image = ((System.Drawing.Image)(resources.GetObject("newGameBox.Image")));
            this.newGameBox.Location = new System.Drawing.Point(42, 61);
            this.newGameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newGameBox.Name = "newGameBox";
            this.newGameBox.Size = new System.Drawing.Size(370, 118);
            this.newGameBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newGameBox.TabIndex = 0;
            this.newGameBox.TabStop = false;
            this.newGameBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newGameBox_MouseDown);
            this.newGameBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newGameBox_MouseUp);
            // 
            // difficultyBox
            // 
            this.difficultyBox.Image = ((System.Drawing.Image)(resources.GetObject("difficultyBox.Image")));
            this.difficultyBox.Location = new System.Drawing.Point(42, 184);
            this.difficultyBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(183, 118);
            this.difficultyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.difficultyBox.TabIndex = 1;
            this.difficultyBox.TabStop = false;
            // 
            // exitBox
            // 
            this.exitBox.Image = ((System.Drawing.Image)(resources.GetObject("exitBox.Image")));
            this.exitBox.Location = new System.Drawing.Point(230, 184);
            this.exitBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(183, 118);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBox.TabIndex = 2;
            this.exitBox.TabStop = false;
            // 
            // githubBox
            // 
            this.githubBox.Image = ((System.Drawing.Image)(resources.GetObject("githubBox.Image")));
            this.githubBox.Location = new System.Drawing.Point(417, 61);
            this.githubBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.githubBox.Name = "githubBox";
            this.githubBox.Size = new System.Drawing.Size(183, 241);
            this.githubBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.githubBox.TabIndex = 3;
            this.githubBox.TabStop = false;
            this.githubBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.githubBox_MouseUp);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(764, 374);
            this.Controls.Add(this.githubBox);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.difficultyBox);
            this.Controls.Add(this.newGameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(659, 413);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.newGameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox newGameBox;
        private System.Windows.Forms.PictureBox difficultyBox;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox githubBox;
    }
}