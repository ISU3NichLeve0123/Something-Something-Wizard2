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
    public class Lightining_Wizard : Wizards
    {

        public int objectX, objectY, objectSize;

        public Lightining_Wizard()
        {
            health = 10;
            aiX = 700;
            wizardSelection = 1;
            sizeX = 130;
            sizeY = 232;
            objectX = sizeX + 100;
            objectY = y + 50;
            objectSize = 50;
        }

        public void ObjectMove()
        {

        }

        public bool PlayerCollsion(Wizards aiMega, Wizards aiDK, Wizards aiLK)
        {
            Rectangle rec1 = new Rectangle(aiDK.aiX, aiDK.aiY, aiDK.sizeX, aiDK.sizeY);
            Rectangle rec2 = new Rectangle(aiMega.aiX, aiMega.aiY, aiMega.sizeX, aiMega.sizeY);
            Rectangle rec3 = new Rectangle(aiLK.aiX, aiLK.aiY, aiLK.sizeX, aiLK.sizeY);
            Rectangle rec4 = new Rectangle(objectX, objectY, objectSize, objectSize);
            if (rec4.IntersectsWith(rec3))
            {
                return true;
            }
            else if ((rec4.IntersectsWith(rec2)))
            {
                return true;
            }
            else if (rec4.IntersectsWith(rec1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Collsion(Wizards mega, Wizards dk, Wizards lk)
        {
            Rectangle rec1 = new Rectangle(dk.x, dk.y, dk.sizeX, dk.sizeY);
            Rectangle rec2 = new Rectangle(mega.x, mega.y, mega.sizeX, mega.sizeY);
            Rectangle rec3 = new Rectangle(lk.x, lk.y, lk.sizeX, lk.sizeY);
            Rectangle rec4 = new Rectangle(objectX, objectY, objectSize, objectSize);
            if (rec4.IntersectsWith(rec3))
            {
                return true;
            }
            else if ((rec4.IntersectsWith(rec2)))
            {
                return true;
            }
            else if (rec4.IntersectsWith(rec1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public void Sparks(PaintEventArgs e, Lightining_Wizard lk)
        {
            objectX += 4;
            e.Graphics.DrawString(lk.name + " used Sparks!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Sparks, lk.objectX, lk.objectY, lk.objectSize, lk.objectSize);
            GameScreen.AttackEndDetails();
        }

            public void Crackle(PaintEventArgs e, Lightining_Wizard lk)
        {
            objectX += 4;
            e.Graphics.DrawString(lk.name + " used Crackle!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Crackle, lk.objectX, lk.objectY, lk.objectSize, lk.objectSize);
            GameScreen.AttackEndDetails();
        }

        public void Lighting(PaintEventArgs e, Lightining_Wizard lk)
        {
            if (GameScreen.aiTurn == true) { objectX -= 4; } else { objectX += 4;}  
            e.Graphics.DrawString(lk.name + " used Lightining!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Lightining, lk.objectX, lk.objectY, lk.objectSize, lk.objectSize);
            GameScreen.AttackEndDetails();
        }

        public void Lizards(PaintEventArgs e, Lightining_Wizard lk)
        {
            objectX += 4;
            e.Graphics.DrawString(lk.name + " used Lizards!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Lizards, lk.objectX, lk.objectY, lk.objectSize, lk.objectSize);
            GameScreen.AttackEndDetails();
        }
    }
}
