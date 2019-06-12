namespace Something_Something_Wizards
{
    partial class WinScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.winLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.winLabel.Location = new System.Drawing.Point(29, 22);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(784, 123);
            this.winLabel.TabIndex = 0;
            this.winLabel.Text = "Congraulations! You\'ve survived another round in hell, hope ya like it here, as w" +
    "ere just getting started....";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mainMenuButton.ForeColor = System.Drawing.Color.Maroon;
            this.mainMenuButton.Location = new System.Drawing.Point(69, 379);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(131, 48);
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.ForeColor = System.Drawing.Color.Crimson;
            this.playAgainButton.Location = new System.Drawing.Point(325, 379);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(128, 48);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.Location = new System.Drawing.Point(580, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 48);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.winLabel);
            this.Name = "WinScreen";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button exitButton;
    }
}
