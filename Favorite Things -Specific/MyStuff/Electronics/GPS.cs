using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Favorite_Things__Specific.MyStuff.Electronics;

namespace Favorite_Things__Specific.MyStuff.Electronics
{
    class GPS : E_Device
    {
        public string Name { get; set; }
        public string LastMapUpdate { get; set; }
        public GPS(string manufacturer, string name, string year, double price, string lastMapUpdate)
        {
            Manufacturer = manufacturer;
            Name = name;
            Year = year;
            Price = price;
            LastMapUpdate = lastMapUpdate;
        }

        public override void Display()
        {
            Console.WriteLine($"               {Manufacturer} {Name} {Year} ${Price}");
            Console.WriteLine($"               Last Map Update: {LastMapUpdate}");
        }

    }
}
