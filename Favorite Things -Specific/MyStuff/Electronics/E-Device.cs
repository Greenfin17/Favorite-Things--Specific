using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Things__Specific.MyStuff.Electronics
{
    abstract class E_Device
    {
        public string Manufacturer { get; set; }
        public string Year { get; set; }
        public double Price { get; set; }

        public abstract void Display();
    }
}
