using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Gazelle : Transport
    {
        public Gazelle()
        {
            Cost = 10;
            MaxVolume = 20;
        }

        public override double CalculateTransportationCost(double weight, double volume)
        {
            return (double)(weight * 1.5 + volume * 0.5);
        }

        public override bool CanHandleCondition(string condition)
        {
            if (condition == "Амортизація" || condition == "Охолодження")
            {

                return true;

            }
            return false;
        }
    }
}
