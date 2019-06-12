namespace Something_Something_Wizards
{
    partial class StartScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Indigo;
            this.welcomeLabel.Location = new System.Drawing.Point(-9, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(949, 67);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Something Somethig Wizard!";
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.nameLabel.Location = new System.Drawing.Point(3, 153);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(439, 67);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "What is your name?";
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Location = new System.Drawing.Point(448, 169);
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(349, 20);
            this.inputNameTextBox.TabIndex = 3;
            // 
            // errorLabel
            // 
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(3, 364);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(813, 67);
            this.errorLabel.TabIndex = 4;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Black;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.Cyan;
            this.continueButton.Location = new System.Drawing.Point(349, 316);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(142, 64);
            this.continueButton.TabIndex = 5;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartScreen
            // 
            this.BackgroundImage = global::Something_Something_Wizards.Properties.Resources.Wizardry_Logo;
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.inputNameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.label2);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(816, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button continueButton;
    }
}
