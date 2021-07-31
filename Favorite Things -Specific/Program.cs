using System;
using Favorite_Things__Specific.MyStuff;
using Favorite_Things__Specific.MyStuff.Tools;
using System.Collections.Generic;

namespace Favorite_Things__Specific
{

    class Program
    {
        static void LoadVehicles(ref List<Vehicle> vehicleList)
        {
            ICETruck ford150 = new("2020", "Ford", "F-150", 15000, "10-speed shiftable automatic", 
                                    "Four wheel drive", 290, 265, 67.1, 50.6);
            ElectricCar focusElectric = new ElectricCar("2013", "Ford", "Focus Electric", 44000, .31, .11);
            ICECar bmwE30 = new ICECar("1987", "BMW", "325is", 324000);
            vehicleList.Add(ford150);
            vehicleList.Add(focusElectric);
            vehicleList.Add(bmwE30);


        }

        static void DisplayVehicles(ref List<Vehicle> vehicleList)
        {
            foreach(var vehicle in vehicleList)
            {
                vehicle.Status();
            }
        }

        static void LoadTools(ref List<HandTool> toolList)
        {
            Socket socket1 = new Socket("          Craftsman", true, "3/8", "13mm");
            Wrench craftsmanCommbination1_2 = new Wrench("Craftsman", WrenchType.Combination, true, "13mm");
            Wrench skCombination = new Wrench("SK", WrenchType.Combination, true, "13mm");
            Wrench skBox = new Wrench("SK", WrenchType.Box, true, "13mm", "15mm");
            toolList.Add(socket1);
            toolList.Add(craftsmanCommbination1_2);
            toolList.Add(skCombination);
            toolList.Add(skBox);


        }
        static void DisplayTools(ref List<HandTool> toolList)
        {
            foreach(var tool in toolList)
            {
                tool.Display();
            }
            Console.Write('\n');
        }
        static void Main(string[] args)
        {

            List<Vehicle> vehicleList = new List<Vehicle>();
            LoadVehicles(ref vehicleList);
            DisplayVehicles(ref vehicleList);
            List<HandTool> toolList = new List<HandTool>();
            LoadTools(ref toolList);
            DisplayTools(ref toolList);

        }
    }
}
