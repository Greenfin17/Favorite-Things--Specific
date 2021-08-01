using System;
using Favorite_Things__Specific.MyStuff;
using Favorite_Things__Specific.MyStuff.Tools;
using Favorite_Things__Specific.MyStuff.Electronics;
using Favorite_Things__Specific.MyStuff.Vehicles;
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

            Screwdriver cobaltSlotted1 = new Screwdriver("Cobalt", DriverTip.Slotted, 2.0, "1/4");
            Screwdriver cobaltPhillips = new Screwdriver("Cobalt", DriverTip.Phillips, 6.0, "#1");
            Screwdriver wihaTorx = new Screwdriver("Wiha", DriverTip.Torx, 3.5, "T10");
            toolList.Add(cobaltSlotted1);
            toolList.Add(cobaltPhillips);
            toolList.Add(wihaTorx);


        }
        static void DisplayTools(ref List<HandTool> toolList)
        {
            foreach(var tool in toolList)
            {
                tool.Display();
            }
            Console.Write('\n');
        }

        static void LoadElectronics(ref List<E_Device> deviceList)
        {

            Computer Bach = new Computer("DIY", "2017", 850, "Mid-Tower", "Ryzen 7", "16GB", "2TB");
            Computer Saturn = new Computer("HP", "2016", 450, "Laptop", "Intel i5", "16GB", "1TB");
            deviceList.Add(Bach);
            deviceList.Add(Saturn);
        }
        static void DisplayElectronics(ref List<E_Device> deviceList)
        {
            foreach(var device in deviceList)
            {
                device.Display();
            }
        }

        static void loadGPS_Devices(ref List<GPS> deviceList)
        {
            GPS garmin = new GPS("Garmin", "Nuvi", "2012", 122.50, "2020");
            GPS magellan = new GPS("Magellin", "RoadMate", "2013", 114.75, "2020");
            deviceList.Add(garmin);
            deviceList.Add(magellan);
        }

        static void DisplayGPS(ref List<GPS> deviceList)
        {
            foreach(var device in deviceList)
            {
                device.Display();
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("\n               My Specific Favorite Things\n");
            List<Vehicle> vehicleList = new List<Vehicle>();
            LoadVehicles(ref vehicleList);
            Console.WriteLine("               My vehicle list:");
            DisplayVehicles(ref vehicleList);

            List<HandTool> toolList = new List<HandTool>();
            LoadTools(ref toolList);
            Console.WriteLine("               My tool list:");
            DisplayTools(ref toolList);

            List<E_Device> electronicsList = new List<E_Device>();
            LoadElectronics(ref electronicsList);
            Console.WriteLine("               My electronic device list:");
            DisplayElectronics(ref electronicsList);
            
            List<GPS> GPSList = new List<GPS>();
            loadGPS_Devices(ref GPSList);
            Console.WriteLine("               My GPS device list:");
            DisplayGPS(ref GPSList);
        }
    }
}
