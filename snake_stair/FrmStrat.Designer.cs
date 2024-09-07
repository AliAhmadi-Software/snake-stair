namespace snake_stair
{
    partial class FrmStrat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.R_Hard = new System.Windows.Forms.RadioButton();
            this.R_Meduim = new System.Windows.Forms.RadioButton();
            this.R_Easy = new System.Windows.Forms.RadioButton();
            this.SetName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitGame = new System.Windows.Forms.Button();
            this.BtnSetAgain = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.txtNameP5 = new System.Windows.Forms.TextBox();
            this.txtNameP4 = new System.Windows.Forms.TextBox();
            this.txtNameP3 = new System.Windows.Forms.TextBox();
            this.txtNameP2 = new System.Windows.Forms.TextBox();
            this.txtNameP1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.R_Hard);
            this.panel1.Controls.Add(this.R_Meduim);
            this.panel1.Controls.Add(this.R_Easy);
            this.panel1.Controls.Add(this.SetName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PlayerNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 149);
            this.panel1.TabIndex = 0;
            // 
            // R_Hard
            // 
            this.R_Hard.AutoSize = true;
            this.R_Hard.Location = new System.Drawing.Point(348, 58);
            this.R_Hard.Name = "R_Hard";
            this.R_Hard.Size = new System.Drawing.Size(56, 24);
            this.R_Hard.TabIndex = 5;
            this.R_Hard.TabStop = true;
            this.R_Hard.Text = "Hard";
            this.R_Hard.UseVisualStyleBackColor = true;
            // 
            // R_Meduim
            // 
            this.R_Meduim.AutoSize = true;
            this.R_Meduim.Location = new System.Drawing.Point(267, 58);
            this.R_Meduim.Name = "R_Meduim";
            this.R_Meduim.Size = new System.Drawing.Size(75, 24);
            this.R_Meduim.TabIndex = 4;
            this.R_Meduim.TabStop = true;
            this.R_Meduim.Text = "Medium";
            this.R_Meduim.UseVisualStyleBackColor = true;
            // 
            // R_Easy
            // 
            this.R_Easy.AutoSize = true;
            this.R_Easy.Checked = true;
            this.R_Easy.Location = new System.Drawing.Point(203, 58);
            this.R_Easy.Name = "R_Easy";
            this.R_Easy.Size = new System.Drawing.Size(58, 24);
            this.R_Easy.TabIndex = 3;
            this.R_Easy.TabStop = true;
            this.R_Easy.Text = "Easy";
            this.R_Easy.UseVisualStyleBackColor = true;
            // 
            // SetName
            // 
            this.SetName.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetName.Location = new System.Drawing.Point(103, 94);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(394, 40);
            this.SetName.TabIndex = 2;
            this.SetName.Text = "Set Name Of Palyers";
            this.SetName.UseVisualStyleBackColor = true;
            this.SetName.Click += new System.EventHandler(this.SetName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the level of Game:";
            // 
            // PlayerNum
            // 
            this.PlayerNum.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNum.Location = new System.Drawing.Point(229, 9);
            this.PlayerNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PlayerNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PlayerNum.Name = "PlayerNum";
            this.PlayerNum.Size = new System.Drawing.Size(121, 31);
            this.PlayerNum.TabIndex = 0;
            this.PlayerNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Numbers of player:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.ExitGame);
            this.panel2.Controls.Add(this.BtnSetAgain);
            this.panel2.Controls.Add(this.BtnStart);
            this.panel2.Controls.Add(this.txtNameP5);
            this.panel2.Controls.Add(this.txtNameP4);
            this.panel2.Controls.Add(this.txtNameP3);
            this.panel2.Controls.Add(this.txtNameP2);
            this.panel2.Controls.Add(this.txtNameP1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 371);
            this.panel2.TabIndex = 1;
            // 
            // ExitGame
            // 
            this.ExitGame.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGame.ForeColor = System.Drawing.Color.Black;
            this.ExitGame.Location = new System.Drawing.Point(103, 318);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(394, 40);
            this.ExitGame.TabIndex = 7;
            this.ExitGame.Text = "Exit";
            this.ExitGame.UseVisualStyleBackColor = true;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // BtnSetAgain
            // 
            this.BtnSetAgain.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetAgain.ForeColor = System.Drawing.Color.Black;
            this.BtnSetAgain.Location = new System.Drawing.Point(103, 272);
            this.BtnSetAgain.Name = "BtnSetAgain";
            this.BtnSetAgain.Size = new System.Drawing.Size(394, 40);
            this.BtnSetAgain.TabIndex = 6;
            this.BtnSetAgain.Text = "Cancel";
            this.BtnSetAgain.UseVisualStyleBackColor = true;
            this.BtnSetAgain.Click += new System.EventHandler(this.BtnSetAgain_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.Black;
            this.BtnStart.Location = new System.Drawing.Point(103, 226);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(394, 40);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Lets Go!";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtNameP5
            // 
            this.txtNameP5.Enabled = false;
            this.txtNameP5.Location = new System.Drawing.Point(222, 184);
            this.txtNameP5.Name = "txtNameP5";
            this.txtNameP5.Size = new System.Drawing.Size(302, 27);
            this.txtNameP5.TabIndex = 4;
            // 
            // txtNameP4
            // 
            this.txtNameP4.Enabled = false;
            this.txtNameP4.Location = new System.Drawing.Point(222, 144);
            this.txtNameP4.Name = "txtNameP4";
            this.txtNameP4.Size = new System.Drawing.Size(302, 27);
            this.txtNameP4.TabIndex = 3;
            // 
            // txtNameP3
            // 
            this.txtNameP3.Enabled = false;
            this.txtNameP3.Location = new System.Drawing.Point(222, 104);
            this.txtNameP3.Name = "txtNameP3";
            this.txtNameP3.Size = new System.Drawing.Size(302, 27);
            this.txtNameP3.TabIndex = 2;
            // 
            // txtNameP2
            // 
            this.txtNameP2.Enabled = false;
            this.txtNameP2.Location = new System.Drawing.Point(222, 64);
            this.txtNameP2.Name = "txtNameP2";
            this.txtNameP2.Size = new System.Drawing.Size(302, 27);
            this.txtNameP2.TabIndex = 1;
            // 
            // txtNameP1
            // 
            this.txtNameP1.Enabled = false;
            this.txtNameP1.Location = new System.Drawing.Point(222, 25);
            this.txtNameP1.Name = "txtNameP1";
            this.txtNameP1.Size = new System.Drawing.Size(302, 27);
            this.txtNameP1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(15, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enter the Name of player[5]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(15, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Enter the Name of player[4]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter the Name of player[3]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(15, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter the Name of player[2]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter the Name of player[1]:";
            // 
            // FrmStrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmStrat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Pannel";
            this.Load += new System.EventHandler(this.FrmStrat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown PlayerNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetName;
        private System.Windows.Forms.TextBox txtNameP5;
        private System.Windows.Forms.TextBox txtNameP4;
        private System.Windows.Forms.TextBox txtNameP3;
        private System.Windows.Forms.TextBox txtNameP2;
        private System.Windows.Forms.TextBox txtNameP1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnSetAgain;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.RadioButton R_Hard;
        private System.Windows.Forms.RadioButton R_Meduim;
        private System.Windows.Forms.RadioButton R_Easy;
    }
}