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
   public class MEGAMEME : Wizards
    {
         public int objectX, objectY, objectSize;
        
        public MEGAMEME()
        {
            health = 10;
            wizardSelection = 1;
            sizeX = 267;
            sizeY = 189;
            objectX = sizeX + 100;
            objectY = y + 50;
            objectSize = 50;                    
        }

        public void ObjectMove()
        {
            objectX += 4;
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
            public void explosion(PaintEventArgs e, MEGAMEME mega)
        {
            if (GameScreen.aiTurn == true) { objectX -= 4; } else { objectX += 4; }
            e.Graphics.DrawString(mega.name + " used explosion!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize);
            GameScreen.AttackEndDetails();
        }

        public void Explosion(PaintEventArgs e, MEGAMEME mega)
        {
            if (GameScreen.aiTurn == true) { objectX -= 4; } else { objectX += 4; }
            e.Graphics.DrawString(mega.name + " used Explosion!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize);
            GameScreen.AttackEndDetails();
        }

        public void EXPLOSION(PaintEventArgs e, MEGAMEME mega)
        {
            if (GameScreen.aiTurn == true) { objectX -= 4; } else { objectX += 4; }
            if (GameScreen.aiTurn == false) { e.Graphics.DrawString(mega.name + " used EXPLOSION!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0); }
            else { e.Graphics.DrawString(GameScreen.aiMega.name + " used EXPLOSION!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0); }
            if (GameScreen.aiTurn == false) { e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize); }
            else { e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, objectX, mega.objectY, mega.objectSize, mega.objectSize); }
            GameScreen.AttackEndDetails();
        }

        public void Baka(PaintEventArgs e, MEGAMEME mega)
        {
            if (GameScreen.aiTurn == true) { objectX -= 4; } else { objectX += 4; }
            e.Graphics.DrawString(mega.name + " used Baka!", GameScreen.drawFont, GameScreen.drawBrush, 200, 0);
            e.Graphics.DrawImage(Properties.Resources.Wizardry_Logo, mega.objectX, mega.objectY, mega.objectSize, mega.objectSize);
            GameScreen.AttackEndDetails();
        }
    }
}
