using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlassShopPlus.Entity
{
    class Len : Product
    {
        public string Type { get; set; }
        public string Sight { get; set; }
        public float Sph { get; set; }
        public float Cyl { get; set; }

        public string getName()
        {
            string name = "";

            name += this.Brand + " ";
            name += "เลนส์" + this.Type;
            name += "สายตา" + this.Sight;
            name += " [" + this.Sph + ", " + this.Cyl + "]";

            return name;
        }
    }
}
