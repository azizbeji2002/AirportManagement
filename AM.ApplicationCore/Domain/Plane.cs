namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public string PlaneType { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public Plane(string planeType, int capacity, DateTime manufactureDate)
        {
            PlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
        }

        public override string ToString() =>
            $"[Plane] Type={PlaneType}, Capacity={Capacity}, ManufactureDate={ManufactureDate:dd/MM/yyyy}";
    }
}