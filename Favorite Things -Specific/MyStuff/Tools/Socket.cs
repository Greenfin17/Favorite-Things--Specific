using System; using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Favorite_Things__Specific.MyStuff;

namespace Favorite_Things__Specific.MyStuff.Tools
{
    class Socket : HandTool
    {
        public string DriveSize { get; set; }
        public string SocketSize { get; set; }

        bool _isMetric;

        public Socket(string brand, bool metric, string driveSize, string socketSize) {
            Brand = brand;
            _isMetric = metric;            Type = HandToolType.Socket;            DriveSize = driveSize;
            SocketSize = socketSize;
        }
        public override void Display()
        {
            Console.WriteLine($"     {Brand} {DriveSize} drive {SocketSize} socket.");
        }
    }
}
