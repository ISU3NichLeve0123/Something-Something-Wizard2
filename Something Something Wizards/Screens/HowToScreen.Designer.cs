namespace Something_Something_Wizards
{
    partial class HowToScreen
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
            this.howToPlayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToPlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.howToPlayLabel.Location = new System.Drawing.Point(233, 0);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(302, 88);
            this.howToPlayLabel.TabIndex = 0;
            this.howToPlayLabel.Text = "How to Play";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(211, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 230);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert Text For Actual Buttons When I have Them";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(632, 384);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(149, 66);
            this.mainMenuButton.TabIndex = 2;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(46, 384);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(149, 66);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // HowToScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Something_Something_Wizards.Properties.Resources.Questionable_Question_Mark;
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.howToPlayLabel);
            this.Name = "HowToScreen";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label howToPlayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button playButton;
    }
}
