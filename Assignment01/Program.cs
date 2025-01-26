//==========================================================
// Student Number	: S10259224
// Student Name	: Kerwin Li
// Partner Name	: Ser Hao
//==========================================================

using Assignment01;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

class Program
{

    public static void LoadAirlinePath(string airlinePath)
    {
        if (File.Exists(airlinePath))
        {
            string[] lines = File.ReadAllLines(airlinePath);

            Dictionary<string, Airline> airlineDict = new Dictionary<string, Airline>();
            foreach (var line in lines.Skip(1))
            {
                string[] data = line.Split(',');
                string airlineName = data[0];
                string airlineCode = data[1];

                Airline airlineObj = new Airline(airlineName, airlineCode);

                airlineDict.Add(airlineName, airlineObj);
            }
            Console.WriteLine("Airline loaded successfully");
            Console.WriteLine("Loaded Airlines: ");

            foreach (var airline in airlineDict.Values)
            {
                Console.WriteLine(airline);
            }
        }
        else
        {
            throw new FileNotFoundException("File not found!");
        }
    }

    public static void LoadBoardingPath(string boardingPath)
    {
        if (File.Exists(boardingPath))
        {
            string[] lines = File.ReadAllLines(boardingPath);

            Dictionary<string, BoardingGate> boardingGateDict = new Dictionary<string, BoardingGate>();

            foreach (var line in lines.Skip(1))
            {
                string[] data = line.Split(",");
                string gateName = data[0];
                bool ddjb = bool.Parse(data[1]);
                bool cfft = bool.Parse(data[2]);
                bool lwtt = bool.Parse((data[3]));

                BoardingGate boardingGateObj = new BoardingGate(gateName, cfft, ddjb, lwtt);
                boardingGateDict.Add(gateName, boardingGateObj);
            }
            Console.WriteLine("Boarding gate loaded successfully");
            Console.WriteLine("Loaded boarding gate: ");

            foreach (var boardingGate in boardingGateDict.Values)
            {
                Console.WriteLine(boardingGate);
            }
        }
        else
        {
            throw new FileNotFoundException("File not found!");
        }
    }


    public static void LoadFlightPath(string flightPath)
    {
        if (File.Exists(flightPath))
        {
            string[] lines = File.ReadAllLines(flightPath);

            Dictionary<string, Flight> flightPathDict = new Dictionary<string, Flight>();

            foreach (var line in lines.Skip(1))
            {
                string[] data = line.Split(",");

                string flightNumber = data[0];
                string origin = data[1];
                string destination = data[2];
                DateTime departureTime = DateTime.Parse(data[3]);
                string specialReqCode = data[4];

                Flight flightObj = new Flight(flightNumber, origin, destination, departureTime, specialReqCode);

                flightPathDict.Add(flightNumber, flightObj);
            }
            Console.WriteLine("Flight path loaded successfully");
            Console.WriteLine("Loaded flight paths: ");

            foreach (var path in flightPathDict.Values)
            {
                Console.WriteLine(path);
            }
        }
        else
        {
            throw new FileNotFoundException("File not found!");
        }
    }
    public static void Main(string[] args)
    {
        string airlinePath= "airlines.csv";
        string flightsPath= "flights.csv";
        string boardingPath= "boardinggates.csv";

        // Feature 1
        LoadAirlinePath(airlinePath);
        LoadBoardingPath(boardingPath);

        // Feature 2
        LoadFlightPath(flightsPath);

       
    }
}