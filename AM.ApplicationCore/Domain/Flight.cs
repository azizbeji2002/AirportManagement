namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public DateTime FlightDate { get; set; }
        public string Destination { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public Plane Plane { get; set; }
        public int EstimatedDuration { get; set; }
        public List<Passenger> Passengers { get; set; } = new List<Passenger>();

        public Flight(DateTime flightDate, string destination, DateTime effectiveArrival,
                      Plane plane, int estimatedDuration)
        {
            FlightDate = flightDate;
            Destination = destination;
            EffectiveArrival = effectiveArrival;
            Plane = plane;
            EstimatedDuration = estimatedDuration;
        }

        public override string ToString() =>
            $"[Flight] {FlightDate:dd/MM/yyyy HH:mm} → {Destination}, Duration={EstimatedDuration}min, Plane={Plane.PlaneType}";
    }
}