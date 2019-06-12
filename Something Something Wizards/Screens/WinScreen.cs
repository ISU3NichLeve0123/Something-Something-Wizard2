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
    public partial class WinScreen : UserControl
    {
        public WinScreen()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MainScreen g = new MainScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            WizardSelectionScreen g = new WizardSelectionScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }
    }
}
