using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Something_Something_Wizards
{
    public partial class WizardSelectionScreen : UserControl
    {
        int wizardX = 100;
        int wizardY = 100;
        int health = 20;
        int mana = 10;

        public WizardSelectionScreen()
        {
            InitializeComponent();
        }

        private void WizardSelectionScreen_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawImage(Properties.Resources.FUCK_DIMA,50, 100);

            e.Graphics.DrawImage(Properties.Resources.Dima_is_a_shit_influence, 300, 100);

            e.Graphics.DrawImage(Properties.Resources.Light_Wizard, 600, 100);
        }

        private void darknessWizardButton_Click(object sender, EventArgs e)
        {
            OrignalForm.player_Charcter = 1;
            Wizards playerWizard = new Wizards(wizardX, wizardY, mana, health, OrignalForm.player_Charcter, 0, 0, OrignalForm.name);
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen g = new GameScreen();
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
            g.Focus();
        }

        private void fireWizardButton_Click(object sender, EventArgs e)
        {
            OrignalForm.player_Charcter = 2;
            Wizards playerWizard = new Wizards(wizardX, wizardY, mana, health, OrignalForm.player_Charcter, 0, 0, OrignalForm.name);
            Form f = this.FindForm();          
            f.Controls.Remove(this);
            GameScreen g = new GameScreen();
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
            g.Focus();
        }

        private void lightiningWizardButton_Click(object sender, EventArgs e)
        {
            OrignalForm.player_Charcter = 3;
            Wizards playerWizard = new Wizards(wizardX, wizardY, mana, health, OrignalForm.player_Charcter, 0, 0, OrignalForm.name);
            Form f = this.FindForm();           
            f.Controls.Remove(this);
            GameScreen g = new GameScreen();
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
            g.Focus();

        }
    }
}
