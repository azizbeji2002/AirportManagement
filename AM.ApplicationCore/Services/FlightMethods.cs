using System.Reflection;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        // Q16 – Delegates
        public delegate void FlightDetailsDel(Plane plane);
        public delegate double DurationAverageDel(string destination);

        public FlightDetailsDel ShowFlightDetailsDelegate;
        public DurationAverageDel DurationAverageDelegate;

        // Q17 + Q18 – Constructeur
        public FlightMethods()
        {
            // Q17 – méthodes nommées
            ShowFlightDetailsDelegate = ShowFlightDetails;
            DurationAverageDelegate = DurationAverage;

            // Q18 – réaffectation via lambdas
            ShowFlightDetailsDelegate = (plane) =>
            {
                var results = Flights
                    .Where(f => f.Plane.PlaneType == plane.PlaneType)
                    .Select(f => new { f.FlightDate, f.Destination });
                foreach (var r in results)
                    Console.WriteLine($"  Date: {r.FlightDate:dd/MM/yyyy HH:mm:ss}  |  Destination: {r.Destination}");
            };

            DurationAverageDelegate = (destination) =>
                Flights
                    .Where(f => f.Destination == destination)
                    .Average(f => f.EstimatedDuration);
        }

        // Q6 – for
        public List<DateTime> GetFlightDatesFor(string destination)
        {
            var dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
                if (Flights[i].Destination == destination)
                    dates.Add(Flights[i].FlightDate);
            return dates;
        }

        // Q7 – foreach
        public List<DateTime> GetFlightDatesForeach(string destination)
        {
            var dates = new List<DateTime>();
            foreach (var flight in Flights)
                if (flight.Destination == destination)
                    dates.Add(flight.FlightDate);
            return dates;
        }

        // Q8 – filtre dynamique
        public void GetFlights(string filterType, string filterValue)
        {
            PropertyInfo? prop = typeof(Flight).GetProperty(filterType);
            if (prop == null) { Console.WriteLine($"Attribut inconnu : {filterType}"); return; }
            foreach (var flight in Flights)
                if (prop.GetValue(flight)?.ToString() == filterValue)
                    Console.WriteLine(flight);
        }

        // Q9 – LINQ
        public List<DateTime> GetFlightDatesLinq(string destination) =>
            Flights.Where(f => f.Destination == destination)
                   .Select(f => f.FlightDate)
                   .ToList();

        // Q10
        public void ShowFlightDetails(Plane plane)
        {
            var results = from f in Flights
                          where f.Plane.PlaneType == plane.PlaneType
                          select new { f.FlightDate, f.Destination };
            foreach (var r in results)
                Console.WriteLine($"  Date: {r.FlightDate:dd/MM/yyyy HH:mm:ss}  |  Destination: {r.Destination}");
        }

        // Q11
        public int ProgrammedFlightNumber(DateTime startDate) =>
            Flights.Count(f => f.FlightDate >= startDate && f.FlightDate < startDate.AddDays(7));

        // Q12
        public double DurationAverage(string destination) =>
            Flights.Where(f => f.Destination == destination)
                   .Average(f => f.EstimatedDuration);

        // Q13
        public List<Flight> OrderedDurationFlights() =>
            Flights.OrderByDescending(f => f.EstimatedDuration).ToList();

        // Q14
        public List<Traveller> SeniorTravellers(Flight flight) =>
            flight.Passengers
                  .OfType<Traveller>()
                  .OrderBy(t => t.BirthDate)
                  .Take(3)
                  .ToList();

        // Q15
        public void DestinationGroupedFlights()
        {
            var groups = Flights.GroupBy(f => f.Destination).OrderBy(g => g.Key);
            foreach (var group in groups)
            {
                Console.WriteLine($"Destination {group.Key}");
                foreach (var flight in group)
                    Console.WriteLine($"  Décollage : {flight.FlightDate:dd/MM/yyyy HH:mm:ss}");
            }
        }

        // Q19 – reformulation Section II avec méthodes LINQ
        public List<DateTime> GetFlightDatesForLinqExt(string destination) =>
            Flights.Where(f => f.Destination == destination)
                   .Select(f => f.FlightDate)
                   .ToList();

        public void GetFlightsLinqExt(string filterType, string filterValue)
        {
            PropertyInfo? prop = typeof(Flight).GetProperty(filterType);
            if (prop == null) { Console.WriteLine($"Attribut inconnu : {filterType}"); return; }
            Flights.Where(f => prop.GetValue(f)?.ToString() == filterValue)
                   .ToList()
                   .ForEach(Console.WriteLine);
        }
    }
}