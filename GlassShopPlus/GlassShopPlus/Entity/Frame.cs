using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlassShopPlus.Entity
{
    class Frame : Product
    {
        public string Class { get; set; }
        public string Color { get; set; }

        public string getName()
        {
            string name = "";

            name += this.Brand + " ";
            name += "กรอบแว่น";
            name += "รุ่น " + this.Class;
            name += " สี" + this.Color;

            return name;
        }
    }
}
