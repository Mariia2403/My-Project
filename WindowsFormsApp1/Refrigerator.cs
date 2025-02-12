using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Refrigerator : Transport
    {
        public Refrigerator()
        {
            Cost = 30;
            MaxVolume = 40;
        }

        public override double CalculateTransportationCost(double weight, double volume)
        {
            return (double)(weight * 1.5 + volume * 0.9);

        }

        public override bool CanHandleCondition(string condition)
        {
            if (condition == "Охолодження")
                return true;
            return false;
        }
    }
}
