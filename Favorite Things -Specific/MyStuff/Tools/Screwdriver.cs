using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Favorite_Things__Specific.MyStuff;


namespace Favorite_Things__Specific.MyStuff.Tools
{
    class Screwdriver : HandTool
    {
        public DriverTip Tip { get; set; }
        public double Length { get; set; }
        public string TipSize { get; set; }
        public Screwdriver(string brand, DriverTip tip, double length, string tipSize)
        {
            Brand = brand;
            Tip = tip;
            Length = length;
            TipSize = tipSize;
            Type = HandToolType.Screwdriver;
        }

        public override void Display()
        {
            Console.WriteLine($"               {Brand} {Length} inch {TipSize} {Tip} Screwdriver");
        }
    }
}
