using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class EnemyVehicle : Tank
    {
        protected string model;
        public EnemyVehicle() { }
        public EnemyVehicle(string model,int armor_thickness, int gun_dmg) : base(armor_thickness, gun_dmg)
        {

            this.model = model;
            this.armor_thickness = armor_thickness;
            this.gun_dmg = gun_dmg;
        }
            public int getArmorThickness { get { return armor_thickness; } set { armor_thickness = value; } }
        public int getGun_dmg { get { return gun_dmg; } }
        public string getModel { get { return model; } }
        
    }
}

