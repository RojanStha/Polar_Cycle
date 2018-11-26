using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rojan_ASE_PolarCycle
{
    public class hrdata
    {
        //Data Parameter according to version 106
        public int HeartRate { get; set; }
        public double Speed { get; set; }
        public int Cadence { get; set; }
        public int Altitude { get; set; }
        public string TimeStamp { get; set; }

        public int Power { get; set; }
        public int PowerBalancePedalling { get; set; }

        //Only for version 107
        public int AirPressure { get; set; }
    }
}
