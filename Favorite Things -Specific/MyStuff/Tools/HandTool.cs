using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Things__Specific.MyStuff
{
    abstract class HandTool
    {
        public HandToolType Type { get; set; }
        public string Brand { get; set; }

        public abstract void Display();

    }
}
