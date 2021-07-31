using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Things__Specific.MyStuff
{
    class ICETruck : ICECar 
    {
        public string Transmission { get; set; }
        public string DriveType { get; set; }
        public int Horsepower { get; set; }
        public int Torque { get; set; }

        public ICETruck(string year, string make, string model, long odometer, string transmission, string driveType, int horsepower, int torque)  
        {
            Year = year;
            Make = make;
            Model = model;
            Odometer = odometer;
            Transmission = transmission;
            DriveType = driveType;
            Horsepower = horsepower;
            Torque = torque;
        }

        public override void Status()
        {
            string output = $"               {Year } {Make} {Model}\n" +
                            $"               Transmission {Transmission}\n" +
                            $"               Drive: {DriveType}\n" +
                            $"               Horsepower: {Horsepower}\n" +
                            $"               Torque: {Torque}\n" +
                            $"               Odometer: {Odometer}\n" +
                            $"               Total Operating Cost: ${_operationCost,0:F2}\n";

            Console.WriteLine(output);
        }
    }
}
