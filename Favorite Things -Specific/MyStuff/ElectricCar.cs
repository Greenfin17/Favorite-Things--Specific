using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Things__Specific.MyStuff
{
    class ElectricCar : Vehicle
    {

        double _kwhMile;
        double _costKWH;
        public ElectricCar(string year, string make, string model, long odometer, double kwhMile, double costKWH)
        {
            Year = year;
            Make = make;
            Model = model;
            Odometer = odometer;
            _kwhMile = kwhMile;
            _costKWH = costKWH;
            _operationCost = 0;
        }

        public void Drive(int miles)
        {
            Odometer += miles;
            _operationCost += miles * _kwhMile * _costKWH;
        }
        public void SetElectricCost(double kwhMile, double costKwh)
        {
            Console.WriteLine($"               The {Make} uses {kwhMile} killowatts / mile");
            Console.WriteLine($"               The cost per mile is ${costKwh * kwhMile}.");
            _kwhMile = kwhMile;
            _costKWH = costKwh;
        }
    }
}
