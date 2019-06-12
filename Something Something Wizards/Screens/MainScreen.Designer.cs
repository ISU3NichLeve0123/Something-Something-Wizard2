namespace Something_Something_Wizards
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.howToPlayButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(-5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(836, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to Something Something Wizards!";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(142, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 70);
            this.label3.TabIndex = 2;
            this.label3.Text = "Were Magic Goes to Die!";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.DarkRed;
            this.playButton.Image = global::Something_Something_Wizards.Properties.Resources.PURGATORY;
            this.playButton.Location = new System.Drawing.Point(31, 382);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(92, 59);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayButton.ForeColor = System.Drawing.Color.DarkRed;
            this.howToPlayButton.Image = global::Something_Something_Wizards.Properties.Resources.PURGATORY;
            this.howToPlayButton.Location = new System.Drawing.Point(244, 382);
            this.howToPlayButton.Name = "howToPlayButton";
            this.howToPlayButton.Size = new System.Drawing.Size(92, 59);
            this.howToPlayButton.TabIndex = 4;
            this.howToPlayButton.Text = "How To";
            this.howToPlayButton.UseVisualStyleBackColor = true;
            this.howToPlayButton.Click += new System.EventHandler(this.howToPlayButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.DarkRed;
            this.profileButton.Image = global::Something_Something_Wizards.Properties.Resources.PURGATORY;
            this.profileButton.Location = new System.Drawing.Point(471, 382);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(92, 59);
            this.profileButton.TabIndex = 5;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(665, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(-8, 260);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(836, 70);
            this.errorLabel.TabIndex = 7;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Something_Something_Wizards.Properties.Resources.PURGATORY;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.howToPlayButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button howToPlayButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label errorLabel;
    }
}
