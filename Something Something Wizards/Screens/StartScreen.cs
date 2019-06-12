using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Something_Something_Wizards
{
    public partial class StartScreen : UserControl
    {

        public StartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //XmlWriter writer = XmlWriter.Create("Resources/Profile.xml", null);
            //writer.WriteStartElement("Wizard");
            ////Start an element 
            //writer.WriteStartElement("Profile");
            ////Write sub-elements 
            //writer.WriteElementString("name", inputNameTextBox.Text);
            //// end the element 
            //writer.WriteEndElement();
            //// end the root element 
            //writer.WriteEndElement();
            ////Write the XML to file and close the writer 
            //writer.Close();
            Form f = this.FindForm();
            MainScreen g = new MainScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
            OrignalForm.name = inputNameTextBox.Text;

        }
    }
}
