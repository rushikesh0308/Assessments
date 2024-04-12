using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    public class Vehicle
    {
        public void addFuel()
        {
            Console.WriteLine("add Fuel");
        }
    }

    public class Car : Vehicle 
    {
        public void addFuel()
        {
            Console.WriteLine("Petrol");
        }
    }
    public class VehicleDemo
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();

            v1.addFuel();
        }
    }
    
}
