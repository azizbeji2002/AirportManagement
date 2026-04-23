namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public Traveller(string firstName, string lastName, string email,
                         DateTime birthDate, string healthInfo, string nationality)
            : base(firstName, lastName, email, birthDate)
        {
            HealthInformation = healthInfo;
            Nationality = nationality;
        }

        public override string ToString() =>
            $"[Traveller] {FirstName} {LastName}, Nationality={Nationality}, Health={HealthInformation}";
    }
}