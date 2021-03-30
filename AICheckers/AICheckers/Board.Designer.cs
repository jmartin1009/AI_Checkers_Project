
namespace AICheckers {
    partial class Board {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnMoveNorthWest = new System.Windows.Forms.Button();
            this.btnMoveNorthEast = new System.Windows.Forms.Button();
            this.btnMoveSouthWest = new System.Windows.Forms.Button();
            this.btnMoveSouthEast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoveNorthWest
            // 
            this.btnMoveNorthWest.Location = new System.Drawing.Point(555, 45);
            this.btnMoveNorthWest.Name = "btnMoveNorthWest";
            this.btnMoveNorthWest.Size = new System.Drawing.Size(75, 23);
            this.btnMoveNorthWest.TabIndex = 0;
            this.btnMoveNorthWest.Text = "Move NW";
            this.btnMoveNorthWest.UseVisualStyleBackColor = true;
            this.btnMoveNorthWest.Click += new System.EventHandler(this.btnMoveNorthWest_Click);
            // 
            // btnMoveNorthEast
            // 
            this.btnMoveNorthEast.Location = new System.Drawing.Point(673, 45);
            this.btnMoveNorthEast.Name = "btnMoveNorthEast";
            this.btnMoveNorthEast.Size = new System.Drawing.Size(75, 23);
            this.btnMoveNorthEast.TabIndex = 1;
            this.btnMoveNorthEast.Text = "Move NE";
            this.btnMoveNorthEast.UseVisualStyleBackColor = true;
            this.btnMoveNorthEast.Click += new System.EventHandler(this.btnMoveNorthEast_Click);
            // 
            // btnMoveSouthWest
            // 
            this.btnMoveSouthWest.Location = new System.Drawing.Point(555, 109);
            this.btnMoveSouthWest.Name = "btnMoveSouthWest";
            this.btnMoveSouthWest.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSouthWest.TabIndex = 2;
            this.btnMoveSouthWest.Text = "Move SW";
            this.btnMoveSouthWest.UseVisualStyleBackColor = true;
            this.btnMoveSouthWest.Click += new System.EventHandler(this.btnMoveSouthWest_Click);
            // 
            // btnMoveSouthEast
            // 
            this.btnMoveSouthEast.Location = new System.Drawing.Point(673, 108);
            this.btnMoveSouthEast.Name = "btnMoveSouthEast";
            this.btnMoveSouthEast.Size = new System.Drawing.Size(75, 23);
            this.btnMoveSouthEast.TabIndex = 3;
            this.btnMoveSouthEast.Text = "Move SE";
            this.btnMoveSouthEast.UseVisualStyleBackColor = true;
            this.btnMoveSouthEast.Click += new System.EventHandler(this.btnMoveSouthEast_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoveSouthEast);
            this.Controls.Add(this.btnMoveSouthWest);
            this.Controls.Add(this.btnMoveNorthEast);
            this.Controls.Add(this.btnMoveNorthWest);
            this.Name = "Board";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoveNorthWest;
        private System.Windows.Forms.Button btnMoveNorthEast;
        private System.Windows.Forms.Button btnMoveSouthWest;
        private System.Windows.Forms.Button btnMoveSouthEast;
    }
}

