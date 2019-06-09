namespace RussianRouletteProject
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblShots = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblWinLoose = new System.Windows.Forms.Label();
            this.checkFireYou = new System.Windows.Forms.CheckBox();
            this.checkFireAway = new System.Windows.Forms.CheckBox();
            this.lblSpinNum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(623, 130);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(119, 35);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Bullet";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin.Location = new System.Drawing.Point(623, 171);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(119, 35);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Spin Chamber";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.Location = new System.Drawing.Point(623, 212);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(119, 35);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.SystemColors.Control;
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFire.Location = new System.Drawing.Point(604, 253);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(138, 60);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "FIRE";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblShots
            // 
            this.lblShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShots.Location = new System.Drawing.Point(677, 368);
            this.lblShots.Name = "lblShots";
            this.lblShots.Size = new System.Drawing.Size(64, 23);
            this.lblShots.TabIndex = 4;
            this.lblShots.Text = "label2";
            // 
            // lblLives
            // 
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(678, 334);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(64, 23);
            this.lblLives.TabIndex = 6;
            this.lblLives.Text = "label1";
            // 
            // lblWinLoose
            // 
            this.lblWinLoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLoose.Location = new System.Drawing.Point(12, 403);
            this.lblWinLoose.Name = "lblWinLoose";
            this.lblWinLoose.Size = new System.Drawing.Size(570, 77);
            this.lblWinLoose.TabIndex = 7;
            this.lblWinLoose.Text = "label3";
            this.lblWinLoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkFireYou
            // 
            this.checkFireYou.BackColor = System.Drawing.Color.White;
            this.checkFireYou.Location = new System.Drawing.Point(623, 48);
            this.checkFireYou.Name = "checkFireYou";
            this.checkFireYou.Size = new System.Drawing.Size(119, 24);
            this.checkFireYou.TabIndex = 8;
            this.checkFireYou.Text = "Fire at Santa";
            this.checkFireYou.UseVisualStyleBackColor = false;
            // 
            // checkFireAway
            // 
            this.checkFireAway.BackColor = System.Drawing.Color.White;
            this.checkFireAway.Location = new System.Drawing.Point(623, 79);
            this.checkFireAway.Name = "checkFireAway";
            this.checkFireAway.Size = new System.Drawing.Size(119, 24);
            this.checkFireAway.TabIndex = 9;
            this.checkFireAway.Text = "Fire away";
            this.checkFireAway.UseVisualStyleBackColor = false;
            // 
            // lblSpinNum
            // 
            this.lblSpinNum.Location = new System.Drawing.Point(601, 451);
            this.lblSpinNum.Name = "lblSpinNum";
            this.lblSpinNum.Size = new System.Drawing.Size(141, 23);
            this.lblSpinNum.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fire Away Left: ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(540, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Shots Fired: ";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 48);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Back to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wins:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(112, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Losses:";
            // 
            // lblWins
            // 
            this.lblWins.Location = new System.Drawing.Point(195, 12);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(71, 23);
            this.lblWins.TabIndex = 19;
            this.lblWins.Text = "label3";
            // 
            // lblLosses
            // 
            this.lblLosses.Location = new System.Drawing.Point(195, 42);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(71, 23);
            this.lblLosses.TabIndex = 20;
            this.lblLosses.Text = "label3";
            // 
            // picBox1
            // 
            this.picBox1.Image = global::RussianRouletteProject.Resource1.Santa;
            this.picBox1.Location = new System.Drawing.Point(383, 60);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(147, 200);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox1.TabIndex = 15;
            this.picBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RussianRouletteProject.Resource1.Gun;
            this.pictureBox2.Location = new System.Drawing.Point(12, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 289);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(770, 503);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSpinNum);
            this.Controls.Add(this.lblWinLoose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkFireAway);
            this.Controls.Add(this.checkFireYou);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblShots);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Russian Roulette - Santa Edition";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblShots;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblWinLoose;
        private System.Windows.Forms.CheckBox checkFireYou;
        private System.Windows.Forms.CheckBox checkFireAway;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSpinNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLosses;
    }
}

