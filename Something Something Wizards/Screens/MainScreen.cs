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
    public partial class MainScreen : UserControl
    {
        int counter = 0;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "Why do you want to leave this place? It's so MAGICAL";
            counter++;
            if(counter >= 10)
            {
                Application.Exit();
            }

        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            HowToScreen g = new HowToScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            ProfileScreen g = new ProfileScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            WizardSelectionScreen g = new WizardSelectionScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }
    }
    }

