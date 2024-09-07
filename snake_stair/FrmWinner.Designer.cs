namespace snake_stair
{
    partial class FrmWinner
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
            this.LblWinnerUSer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblWinnerUSer
            // 
            this.LblWinnerUSer.AutoSize = true;
            this.LblWinnerUSer.BackColor = System.Drawing.Color.Transparent;
            this.LblWinnerUSer.ForeColor = System.Drawing.Color.Red;
            this.LblWinnerUSer.Location = new System.Drawing.Point(185, 9);
            this.LblWinnerUSer.Name = "LblWinnerUSer";
            this.LblWinnerUSer.Size = new System.Drawing.Size(269, 23);
            this.LblWinnerUSer.TabIndex = 2;
            this.LblWinnerUSer.Text = "User[----] (------) Win The Game!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::snake_stair.Properties.Resources.Winner;
            this.pictureBox1.Location = new System.Drawing.Point(527, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ExitGame
            // 
            this.ExitGame.Location = new System.Drawing.Point(245, 414);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(138, 29);
            this.ExitGame.TabIndex = 3;
            this.ExitGame.Text = "Exit";
            this.ExitGame.UseVisualStyleBackColor = true;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // FrmWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snake_stair.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 449);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.LblWinnerUSer);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winer";
            this.Load += new System.EventHandler(this.FrmWinner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitGame;
        public System.Windows.Forms.Label LblWinnerUSer;
    }
}