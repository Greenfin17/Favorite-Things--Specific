using System;
using Favorite_Things__Specific.MyStuff;

namespace Favorite_Things__Specific
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            ICETruck ford150 = new ICETruck("2020", "Ford", "F-150", 15000, "10-speed shiftable automatic", "Four wheel drive", 290, 265);

            ford150.Status();
        }
    }
}
