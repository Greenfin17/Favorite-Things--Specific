using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Favorite_Things__Specific.MyStuff;

namespace Favorite_Things__Specific.MyStuff.Tools
{
    class Wrench : HandTool
    {
        public string FirstSize { get; set; }
        public string SecondSize { get; set; }
        public WrenchType WrenchStyle;
        bool _isMetric;

        public Wrench(string brand, WrenchType wrenchStyle, bool isMetric, string firstSize, string secondSize = "")
        {
            Brand = brand;
            Type = HandToolType.Socket;
            WrenchStyle = wrenchStyle;
            _isMetric = isMetric;
            FirstSize = firstSize;
            SecondSize = secondSize;
        }

        public override void Display()
        {
            switch (WrenchStyle)
            {
                case (WrenchType.Box):
                case (WrenchType.Open):
                    Console.WriteLine($"               {Brand} {FirstSize} / {SecondSize} {WrenchStyle} wrench.");
                    break;
                case (WrenchType.Adjustable):
                    Console.WriteLine($"               {Brand} {FirstSize} - {SecondSize} {WrenchStyle} wrench.");
                    break;
                case (WrenchType.Combination):
                case (WrenchType.Ratcheting):
                default:
                    Console.WriteLine($"               {Brand} {FirstSize} {WrenchStyle} wrench.");
                    break;
            }
        }
    }
}
