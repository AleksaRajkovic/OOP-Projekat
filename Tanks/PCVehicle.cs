using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    class PCVehicle:Tank
    {
        protected string model;
        protected Ammo HEAT;
        public PCVehicle() { }
        public PCVehicle(string model, int armor_thickness, int gun_dmg,string type,int armor_pen) : base(armor_thickness, gun_dmg)
        {
            this.model=model;
            this.armor_thickness = armor_thickness;
            this.gun_dmg = gun_dmg;
            this.HEAT = new Ammo(type, armor_pen);
        }
        public Ammo getAmmo { get { return HEAT;}}
        public int getArmorThickness { get { return armor_thickness; } set { armor_thickness = value; } }
        public int getGun_dmg { get { return gun_dmg; }  }
        public string getModel{ get { return model; } }
        public override void stats(RichTextBox richTextBoxEvent)
        {
            richTextBoxEvent.Text += "Model = " + model + "\n";
            richTextBoxEvent.Text += "armor = " + armor_thickness.ToString() + "\n";
            richTextBoxEvent.Text += "DMG = " + gun_dmg.ToString() + "\n";
        }
        public static string Welcome()
        {
            return "Welcome and good luck tanker!! \n";
        }
    }
}
