using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Ammo
    {
        protected string type;
        protected int armor_pen;
        public Ammo(string type,int armor_pen)
        {
            this.type = type;
            this.armor_pen = armor_pen;
        }
        public string getType { get { return type; }set { type = value; } }
        public int getPen { get { return armor_pen; } set { armor_pen = value; }  }
    }
}

