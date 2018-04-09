using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlassShopPlus.Entity
{
    class Contact_Len : Product
    {
        public string Duration { get; set; }
        public string Sight { get; set; }
        public float Sph { get; set; }

        public string getName()
        {
            string name = "";

            name += this.Brand + " ";
            name += "คอนแทคเลนส์";
            name += "สายตา" + this.Sight;
            name += "แบบ" + this.Duration;
            name += " [" + this.Sph + "]";

            return name;
        }
    }
}
