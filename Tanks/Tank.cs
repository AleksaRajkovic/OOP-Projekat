using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    class Tank
    {
        protected int armor_thickness;
        protected int gun_dmg;

        public Tank() { }
        public Tank(int armor_thickness, int gun_dmg)
        {
            this.armor_thickness = armor_thickness;
            this.gun_dmg = gun_dmg;
        }

        public virtual void stats(RichTextBox richTextBoxEvent)
        {
            richTextBoxEvent.Text += "armor = "+ armor_thickness.ToString()+"\n";
            richTextBoxEvent.Text += "DMG = " + gun_dmg.ToString() + "\n";
        }

    }
}
