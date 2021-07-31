using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Things__Specific.MyStuff
{
    class ICECar : Vehicle
    {
        double Mpg { get; set; }

        public ICECar(string year, string make, string model, long odometer)
        {
            Year = year;
            Make = make;
            Model = model;
            Odometer = odometer;
            _operationCost = 0;
        }

        public ICECar()
        {

        }

        public void Drive(int miles, double costPerGallon)
        {
            Console.WriteLine($"               Driving the {Make} {miles} miles.\n");
            Odometer += miles;
            _operationCost += (miles / Mpg) * costPerGallon;
        }
    }
}
