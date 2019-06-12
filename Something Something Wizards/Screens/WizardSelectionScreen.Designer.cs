namespace Something_Something_Wizards
{
    partial class WizardSelectionScreen
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
            this.selectionLabel = new System.Windows.Forms.Label();
            this.fireWizardButton = new System.Windows.Forms.Button();
            this.lightiningWizardButton = new System.Windows.Forms.Button();
            this.deathWizardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectionLabel
            // 
            this.selectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.selectionLabel.Location = new System.Drawing.Point(147, 0);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(836, 70);
            this.selectionLabel.TabIndex = 2;
            this.selectionLabel.Text = "Wizard Selection Screen";
            // 
            // fireWizardButton
            // 
            this.fireWizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.fireWizardButton.ForeColor = System.Drawing.Color.Red;
            this.fireWizardButton.Location = new System.Drawing.Point(314, 403);
            this.fireWizardButton.Name = "fireWizardButton";
            this.fireWizardButton.Size = new System.Drawing.Size(162, 46);
            this.fireWizardButton.TabIndex = 3;
            this.fireWizardButton.Text = "Fire Wizard";
            this.fireWizardButton.UseVisualStyleBackColor = true;
            this.fireWizardButton.Click += new System.EventHandler(this.fireWizardButton_Click);
            // 
            // lightiningWizardButton
            // 
            this.lightiningWizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lightiningWizardButton.ForeColor = System.Drawing.Color.Indigo;
            this.lightiningWizardButton.Location = new System.Drawing.Point(585, 403);
            this.lightiningWizardButton.Name = "lightiningWizardButton";
            this.lightiningWizardButton.Size = new System.Drawing.Size(199, 46);
            this.lightiningWizardButton.TabIndex = 4;
            this.lightiningWizardButton.Text = "Lightining Wizard";
            this.lightiningWizardButton.UseVisualStyleBackColor = true;
            this.lightiningWizardButton.Click += new System.EventHandler(this.lightiningWizardButton_Click);
            // 
            // deathWizardButton
            // 
            this.deathWizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deathWizardButton.ForeColor = System.Drawing.Color.Black;
            this.deathWizardButton.Location = new System.Drawing.Point(46, 403);
            this.deathWizardButton.Name = "deathWizardButton";
            this.deathWizardButton.Size = new System.Drawing.Size(201, 46);
            this.deathWizardButton.TabIndex = 5;
            this.deathWizardButton.Text = "Death Wizard";
            this.deathWizardButton.UseVisualStyleBackColor = true;
            this.deathWizardButton.Click += new System.EventHandler(this.darknessWizardButton_Click);
            // 
            // WizardSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Something_Something_Wizards.Properties.Resources.PURGATORY;
            this.Controls.Add(this.deathWizardButton);
            this.Controls.Add(this.lightiningWizardButton);
            this.Controls.Add(this.fireWizardButton);
            this.Controls.Add(this.selectionLabel);
            this.Name = "WizardSelectionScreen";
            this.Size = new System.Drawing.Size(816, 489);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WizardSelectionScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Button fireWizardButton;
        private System.Windows.Forms.Button lightiningWizardButton;
        private System.Windows.Forms.Button deathWizardButton;
    }
}
