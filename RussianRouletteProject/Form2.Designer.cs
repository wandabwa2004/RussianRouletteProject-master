namespace RussianRouletteProject
{
    partial class Form2
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
            this.menuBtnSanta = new System.Windows.Forms.Button();
            this.menuBtnBatman = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuBtnSanta
            // 
            this.menuBtnSanta.BackColor = System.Drawing.Color.Green;
            this.menuBtnSanta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtnSanta.ForeColor = System.Drawing.Color.White;
            this.menuBtnSanta.Location = new System.Drawing.Point(35, 130);
            this.menuBtnSanta.Name = "menuBtnSanta";
            this.menuBtnSanta.Size = new System.Drawing.Size(152, 86);
            this.menuBtnSanta.TabIndex = 0;
            this.menuBtnSanta.Text = "Santa Claus";
            this.menuBtnSanta.UseVisualStyleBackColor = false;
            this.menuBtnSanta.Click += new System.EventHandler(this.menuBtnSanta_Click);
            // 
            // menuBtnBatman
            // 
            this.menuBtnBatman.BackColor = System.Drawing.Color.Black;
            this.menuBtnBatman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtnBatman.ForeColor = System.Drawing.Color.White;
            this.menuBtnBatman.Location = new System.Drawing.Point(209, 130);
            this.menuBtnBatman.Name = "menuBtnBatman";
            this.menuBtnBatman.Size = new System.Drawing.Size(152, 86);
            this.menuBtnBatman.TabIndex = 1;
            this.menuBtnBatman.Text = "Batman";
            this.menuBtnBatman.UseVisualStyleBackColor = false;
            this.menuBtnBatman.Click += new System.EventHandler(this.menuBtnBatman_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who do you love more...?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Think carefully...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuBtnBatman);
            this.Controls.Add(this.menuBtnSanta);
            this.Name = "Form2";
            this.Text = "Russian Roulette - Think Carefully";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtnSanta;
        private System.Windows.Forms.Button menuBtnBatman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}