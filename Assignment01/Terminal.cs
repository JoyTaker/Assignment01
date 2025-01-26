
using System;
using System.Collections.Generic;
using Assignment01;

=====================================================
// Student Number	: S102677555
// Student Name	: Ser Hao
// Partner Name	: Kerwin Li
//==========================================================
public class Terminal
{
    public string TerminalName { get; set; }
    public Dictionary<string, Airline> Airlines { get; set; }
    public Dictionary<string, Flight> Flights { get; set; }
    public Dictionary<string, BoardingGate> BoardingGates { get; set; }
    public Dictionary<string, double> GateFees { get; set; }

    public Terminal(string terminalName)
    {
        TerminalName = terminalName;
        Airlines = new Dictionary<string, Airline>();
        Flights = new Dictionary<string, Flight>();
        BoardingGates = new Dictionary<string, BoardingGate>();
        GateFees = new Dictionary<string, double>();
    }
}
