using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_Things__Specific.MyStuff
{
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public long Odometer { get; set; }

        protected double _operationCost;

    //    public abstract void Repair(double cost);
        public virtual void Repair(double cost)
        {
            Console.WriteLine($"               Reparing the {Make}");
            Console.WriteLine($"               This repair cost {cost,5:F2}\n");
            _operationCost += cost;
        }
        public virtual void Status()
        {
            string output = $"               {Year } {Make} {Model}\n" +
                            $"               Odometer: {Odometer}\n" +
                            $"               Total Operating Cost: ${_operationCost,0:F2}\n";

            Console.WriteLine(output);
        }

    }
}
