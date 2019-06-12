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
    public class Death_Wizard : Wizards
    {
        public int objectX, objectY, objectSize;

        public Death_Wizard()
        {
            health = 10;
            wizardSelection = 1;
            objectX = sizeX + 100;
            objectY = y + 50;
            objectSize = 50;
            sizeX = 215;
            sizeY = 235;
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
            else if((rec4.IntersectsWith(rec2)))
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
        public void DeathEyes(PaintEventArgs e, Death_Wizard dk)
        {
            objectX += 4;
            e.Graphics.DrawString(dk.name + " used Death Eyes!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
            GameScreen.AttackEndDetails();
        }
        public void DeathHand(PaintEventArgs e, Death_Wizard dk)
        {
            objectX += 4;           
            e.Graphics.DrawString(dk.name + " used Death Hand!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
            GameScreen.AttackEndDetails();
        }
        public void DeathSword(PaintEventArgs e, Death_Wizard dk)
        {
            if (GameScreen.aiTurn == true) { objectX -= 4; } else { objectX += 4; }
            e.Graphics.DrawString(dk.name + " used Death Sword!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
            GameScreen.AttackEndDetails();
        }
        public void Shout(PaintEventArgs e, Death_Wizard dk)
        {
            objectX += 4;
            e.Graphics.DrawString(dk.name + " Shout!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, dk.objectX, dk.objectY, dk.objectSize, dk.objectSize);
            GameScreen.AttackEndDetails();
        }
    }
}
