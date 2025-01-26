using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//==========================================================
// Student Number	: S10259224
// Student Name	: Kerwin Li
// Partner Name	: Ser Hao
//==========================================================

namespace Assignment01
{
    public class LWTTFlight : Flight
    {
        public double RequestFee { get; set; }

        public LWTTFlight(string flightNumber, string origin, string destination, DateTime expectedTime, string status, double requestFee)
            : base(flightNumber, origin, destination, expectedTime, status)
        {
            RequestFee = requestFee;
        }
    }
}
