namespace AM.ApplicationCore.Domain
{
    public abstract class Passenger : Person
    {
        protected Passenger(string firstName, string lastName, string email, DateTime birthDate)
            : base(firstName, lastName, email, birthDate) { }
    }
}