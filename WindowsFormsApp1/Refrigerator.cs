using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Refrigerator:Transport
    {
        public override double Cost
        {
            get
            {
                return 25;
            }
        }


        public override double Volume
        {
            get
            {
                return 12;
            }
        }
    }
}
