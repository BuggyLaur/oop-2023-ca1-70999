using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1_oop_70999
{
    public class Garage1 : CarPark
    {
        public Garage1(string name, double hourlyRate, double maxCharge) : base(name, hourlyRate, maxCharge)
        {
        }

        public override double CalculateCharges(double hoursParked)
        {
            if (hoursParked <= 3)
                return 2.00;
            else
                return Math.Min(2.00 + (hoursParked - 3) * hourlyRate, maxCharge);
        }
    }
}
