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
    public partial class ProfileScreen : UserControl
    {
        public ProfileScreen()
        {
            InitializeComponent();
            nameOutputlLabel.Text = OrignalForm.name;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            MainScreen g = new MainScreen();
            f.Controls.Remove(this);
            f.Controls.Add(g);
            g.Location = new Point((this.Width - g.Width) / 2, (this.Height - g.Height) / 2);
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {
            saveNameButtons.Visible = true;
            nameOutputlLabel.Text = "";
            nameInputTextBox.Visible = true;
            currentNameLabel.Text = "New Name";
            profileLabel.Text = "Change Name";
            mainMenuButton.Visible = false;

        }

        private void saveNameButtons_Click(object sender, EventArgs e)
        {
                XmlWriter writer = XmlWriter.Create("Resources/Profile.xml", null);
                writer.WriteStartElement("Wizard");
                //Start an element 
                writer.WriteStartElement("Profile");
                //Write sub-elements 
                writer.WriteElementString("name", nameInputTextBox.Text);
                // end the element 
                writer.WriteEndElement();
                // end the root element 
                writer.WriteEndElement();
                //Write the XML to file and close the writer 
                writer.Close();
                OrignalForm.name = nameInputTextBox.Text;
                nameInputTextBox.Text = "";
                saveNameButtons.Visible = false;
                nameOutputlLabel.Text = OrignalForm.name;
                nameInputTextBox.Visible = false;
                currentNameLabel.Text = "Current name";
                profileLabel.Text = "Profile";
                mainMenuButton.Visible = true;               
        }
    }
    }

