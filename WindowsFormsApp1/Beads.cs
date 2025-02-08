using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Beads : Transport
    {
        public override double Cost
        {
            get
            {
                return 15;
            }
        }


        public override double Volume
        {
            get
            {
                return 8;
            }
        }
    }
}
