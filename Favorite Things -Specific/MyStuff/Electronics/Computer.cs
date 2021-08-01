using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Things__Specific.MyStuff.Electronics
{ 
    class Computer : E_Device
    {
        public string Type { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }

        public string DiskSpace { get; set; }

        DateTime _lastUpdate;
        DateTime _lastBackup;

        public Computer(string manufacturer, string year, double price, string type, string processor, string memory, string diskSpace)
        {
            Manufacturer = manufacturer;
            Year = year;
            Price = price;
            Type = type;
            Processor = processor;
            Memory = memory;
            DiskSpace = diskSpace;
            _lastUpdate = DateTime.Now;
            _lastBackup = DateTime.Now;
        }

        public override void Display()
        {
            Console.WriteLine($"               {Manufacturer} {Year} ${Price}");
            Console.WriteLine($"               Type: {Type}");
            Console.WriteLine($"               Processor: {Processor}");
            Console.WriteLine($"               Memory: {Memory}");
            Console.WriteLine($"               Disk Space: {DiskSpace}");
            Console.WriteLine($"               Last Update: {_lastUpdate}");
            Console.WriteLine($"               Last Backup: {_lastBackup}\n");
        }

        public void Update()
        {
            Console.WriteLine($"               Updating the {Type}");
            Console.WriteLine($"               The last Update was: {_lastUpdate}\n");
            _lastUpdate = DateTime.Now;
        }

        public void Virus()
        {
            string message = new string(@"
8    8            88                                                                           8  
8    8 eeeee e   e 8 ee   e eeee   eeeee  eeee eeee eeeee   e   e eeeee eeee e   e  eeee eeeee 88 
8eeee8 8  88 8   8   88   8 8      8   8  8    8    8   8   8   8 8   8 8  8 8   8  8    8   8 88 
  88   8   8 8e  8   88  e8 8eee   8eee8e 8eee 8eee 8e  8   8eee8 8eee8 8e   8eee8e 8eee 8e  8 88 
  88   8   8 88  8    8  8  88     88   8 88   88   88  8   88  8 88  8 88   88   8 88   88  8    
  88   8eee8 88ee8    8ee8  88ee   88eee8 88ee 88ee 88  8   88  8 88  8 88e8 88   8 88ee 88ee8 88 
");
            Console.Write(message);
            Console.Write('\n');
        }
        public void Backup()
        {

            Console.WriteLine($"               Backing up the {Type}");
            Console.WriteLine($"               The last backup was: {_lastBackup}\n");
            _lastBackup = DateTime.Now;
        }
    }
}
