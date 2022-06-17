namespace RockPaperScissors
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.p2 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.player1_Scissors = new System.Windows.Forms.RadioButton();
            this.player1_Paper = new System.Windows.Forms.RadioButton();
            this.player1_Rock = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.player2_Scissors = new System.Windows.Forms.RadioButton();
            this.player2_Paper = new System.Windows.Forms.RadioButton();
            this.player2_Rock = new System.Windows.Forms.RadioButton();
            this.about = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(474, 68);
            this.p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(45, 13);
            this.p2.TabIndex = 6;
            this.p2.Text = "Player 2";
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(74, 68);
            this.p1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(45, 13);
            this.p1.TabIndex = 7;
            this.p1.Text = "Player 1";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(271, 156);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(56, 28);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.player1_Scissors);
            this.groupBox1.Controls.Add(this.player1_Paper);
            this.groupBox1.Controls.Add(this.player1_Rock);
            this.groupBox1.Location = new System.Drawing.Point(38, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(128, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // player1_Scissors
            // 
            this.player1_Scissors.AutoSize = true;
            this.player1_Scissors.Location = new System.Drawing.Point(14, 72);
            this.player1_Scissors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player1_Scissors.Name = "player1_Scissors";
            this.player1_Scissors.Size = new System.Drawing.Size(64, 17);
            this.player1_Scissors.TabIndex = 2;
            this.player1_Scissors.TabStop = true;
            this.player1_Scissors.Text = "Scissors";
            this.player1_Scissors.UseVisualStyleBackColor = true;
            this.player1_Scissors.CheckedChanged += new System.EventHandler(this.player1_Tesoura_CheckedChanged);
            // 
            // player1_Paper
            // 
            this.player1_Paper.AutoSize = true;
            this.player1_Paper.Location = new System.Drawing.Point(14, 110);
            this.player1_Paper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player1_Paper.Name = "player1_Paper";
            this.player1_Paper.Size = new System.Drawing.Size(53, 17);
            this.player1_Paper.TabIndex = 1;
            this.player1_Paper.TabStop = true;
            this.player1_Paper.Text = "Paper";
            this.player1_Paper.UseVisualStyleBackColor = true;
            this.player1_Paper.CheckedChanged += new System.EventHandler(this.player1_Papel_CheckedChanged);
            // 
            // player1_Rock
            // 
            this.player1_Rock.AutoSize = true;
            this.player1_Rock.Location = new System.Drawing.Point(14, 37);
            this.player1_Rock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player1_Rock.Name = "player1_Rock";
            this.player1_Rock.Size = new System.Drawing.Size(51, 17);
            this.player1_Rock.TabIndex = 0;
            this.player1_Rock.TabStop = true;
            this.player1_Rock.Text = "Rock";
            this.player1_Rock.UseVisualStyleBackColor = true;
            this.player1_Rock.CheckedChanged += new System.EventHandler(this.player1_Pedra_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.player2_Scissors);
            this.groupBox2.Controls.Add(this.player2_Paper);
            this.groupBox2.Controls.Add(this.player2_Rock);
            this.groupBox2.Location = new System.Drawing.Point(437, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(123, 180);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // player2_Scissors
            // 
            this.player2_Scissors.AutoSize = true;
            this.player2_Scissors.Location = new System.Drawing.Point(11, 72);
            this.player2_Scissors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player2_Scissors.Name = "player2_Scissors";
            this.player2_Scissors.Size = new System.Drawing.Size(64, 17);
            this.player2_Scissors.TabIndex = 2;
            this.player2_Scissors.TabStop = true;
            this.player2_Scissors.Text = "Scissors";
            this.player2_Scissors.UseVisualStyleBackColor = true;
            this.player2_Scissors.CheckedChanged += new System.EventHandler(this.player2_Tesoura_CheckedChanged);
            // 
            // player2_Paper
            // 
            this.player2_Paper.AutoSize = true;
            this.player2_Paper.Location = new System.Drawing.Point(11, 110);
            this.player2_Paper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player2_Paper.Name = "player2_Paper";
            this.player2_Paper.Size = new System.Drawing.Size(53, 17);
            this.player2_Paper.TabIndex = 1;
            this.player2_Paper.TabStop = true;
            this.player2_Paper.Text = "Paper";
            this.player2_Paper.UseVisualStyleBackColor = true;
            this.player2_Paper.CheckedChanged += new System.EventHandler(this.player2_Papel_CheckedChanged);
            // 
            // player2_Rock
            // 
            this.player2_Rock.AutoSize = true;
            this.player2_Rock.Location = new System.Drawing.Point(11, 37);
            this.player2_Rock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player2_Rock.Name = "player2_Rock";
            this.player2_Rock.Size = new System.Drawing.Size(51, 17);
            this.player2_Rock.TabIndex = 0;
            this.player2_Rock.TabStop = true;
            this.player2_Rock.Text = "Rock";
            this.player2_Rock.UseVisualStyleBackColor = true;
            this.player2_Rock.CheckedChanged += new System.EventHandler(this.player2_Pedra_CheckedChanged);
            // 
            // about
            // 
            this.about.BackgroundImage = global::Rock_Paper_Scissors.Properties.Resources.about;
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about.Location = new System.Drawing.Point(561, 323);
            this.about.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(30, 32);
            this.about.TabIndex = 11;
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.about);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = " Rock Paper Scissors";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton player1_Scissors;
        private System.Windows.Forms.RadioButton player1_Paper;
        private System.Windows.Forms.RadioButton player1_Rock;
        private System.Windows.Forms.RadioButton player2_Rock;
        private System.Windows.Forms.RadioButton player2_Scissors;
        private System.Windows.Forms.RadioButton player2_Paper;
        private System.Windows.Forms.Button about;
    }
}

