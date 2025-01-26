using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Airline
    {
        public string name { get; set; }
        public string code { get; set; }
        public Dictionary<string, Flight> flights { get; set; }

        public Airline(string name, string code)
        {
            this.name = name;
            this.code = code;
        }

        public bool AddFlight(Flight flightObj)
        {
            if (!flights.ContainsKey(flightObj.FlightNumber))
            {
                flights.Add(flightObj.FlightNumber, flightObj);
                return true;
            }
            return false;
        }

        public double CalculateFees(Flight flightObj)
        {
            double totalFees = 0;

            foreach (var flight in flights.Values)
            {
                if (flight.Destination == "Singapore (SN)")
                {
                    totalFees += 500;
                }
                else if (flight.Origin == "Singapore (SIN)")
                {
                    totalFees += 800;
                }

                totalFees += 300; // boarding gate fees

                if (flight is DDJBFlight)
                {
                    totalFees += ((DDJBFlight)flight).RequestFee;
                }
                else if (flight is CFFTFlight)
                {
                    totalFees += ((CFFTFlight)flight).RequestFee;
                }
                else if (flight is LWTTFlight)
                {
                    totalFees += ((LWTTFlight)flight).RequestFee;
                }
            }

            return totalFees;
        }

        public bool RemoveFlight(Flight flightObj)
        {
            if (flights.ContainsKey(flightObj.FlightNumber))
            {
                flights.Remove(flightObj.FlightNumber);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"name: {name}, code: {code}, Total flights: {flights.Count}";
        }
    }
};

