using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

var flightService = new FlightMethods
{
    Flights = TestData.listFlights
};

// ── Section II ────────────────────────────────────────────────────────────────
Console.WriteLine("=== Q6 – GetFlightDatesFor(\"Paris\") [for] ===");
flightService.GetFlightDatesFor("Paris")
             .ForEach(d => Console.WriteLine($"  {d:dd/MM/yyyy HH:mm:ss}"));

Console.WriteLine("\n=== Q7 – GetFlightDatesForeach(\"Paris\") [foreach] ===");
flightService.GetFlightDatesForeach("Paris")
             .ForEach(d => Console.WriteLine($"  {d:dd/MM/yyyy HH:mm:ss}"));

Console.WriteLine("\n=== Q8 – GetFlights(\"Destination\", \"Madrid\") ===");
flightService.GetFlights("Destination", "Madrid");

// ── Section III ───────────────────────────────────────────────────────────────
Console.WriteLine("\n=== Q9 – GetFlightDatesLinq(\"Paris\") ===");
flightService.GetFlightDatesLinq("Paris")
             .ForEach(d => Console.WriteLine($"  {d:dd/MM/yyyy HH:mm:ss}"));

Console.WriteLine("\n=== Q10 – ShowFlightDetails(Airbus) ===");
flightService.ShowFlightDetails(TestData.Airbus);

Console.WriteLine("\n=== Q11 – ProgrammedFlightNumber(2022-01-01) ===");
Console.WriteLine($"  Nombre = {flightService.ProgrammedFlightNumber(new DateTime(2022, 1, 1))}");

Console.WriteLine("\n=== Q12 – DurationAverage(\"Paris\") ===");
Console.WriteLine($"  Moyenne = {flightService.DurationAverage("Paris"):F2} min");

Console.WriteLine("\n=== Q13 – OrderedDurationFlights() ===");
flightService.OrderedDurationFlights()
             .ForEach(f => Console.WriteLine($"  {f.Destination,10} | {f.EstimatedDuration} min"));

Console.WriteLine("\n=== Q14 – SeniorTravellers(vol #1) ===");
flightService.SeniorTravellers(TestData.listFlights[0])
             .ForEach(t => Console.WriteLine($"  {t.FirstName} {t.LastName} | {t.BirthDate:dd/MM/yyyy}"));

Console.WriteLine("\n=== Q15 – DestinationGroupedFlights() ===");
flightService.DestinationGroupedFlights();

// ── Section IV ────────────────────────────────────────────────────────────────
Console.WriteLine("\n=== Q17/Q18 – ShowFlightDetailsDelegate(Boeing) ===");
flightService.ShowFlightDetailsDelegate(TestData.Boeing);

Console.WriteLine("\n=== Q17/Q18 – DurationAverageDelegate(\"Madrid\") ===");
Console.WriteLine($"  Moyenne = {flightService.DurationAverageDelegate("Madrid"):F2} min");

Console.WriteLine("\n=== Q19 – GetFlightsLinqExt(\"Destination\", \"Paris\") ===");
flightService.GetFlightsLinqExt("Destination", "Paris");

// ── Section V ─────────────────────────────────────────────────────────────────
Console.WriteLine("\n=== Section V – UpperFullName() ===");
foreach (var p in TestData.listFlights[0].Passengers)
    Console.WriteLine($"  {p.UpperFullName()}");