﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//=====================================================
// Student Number	: S102677555
// Student Name	: Ser Hao
// Partner Name	: Kerwin Li
//==========================================================

namespace Assignment01
{
    public class CFFTFlight : Flight
    {
        public double RequestFee { get; set; }

        public CFFTFlight(string flightNumber, string origin, string destination, DateTime expectedTime, string status, double requestFee)
            : base(flightNumber, origin, destination, expectedTime, status)
        {
            RequestFee = requestFee;
        }
    }

}
