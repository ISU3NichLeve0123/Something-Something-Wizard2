using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Something_Something_Wizards
{
    public partial class OrignalForm : Form
    {
        public static string name;
        public static int player_Charcter = 0;
        public OrignalForm()
        {

            InitializeComponent();
            StartScreen g = new StartScreen();
            this.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

    }
}
