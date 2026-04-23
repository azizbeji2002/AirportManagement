using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static string UpperFullName(this Passenger passenger)
        {
            string Capitalise(string s) =>
                string.IsNullOrEmpty(s) ? s : char.ToUpper(s[0]) + s[1..].ToLower();

            return $"{Capitalise(passenger.FirstName)} {Capitalise(passenger.LastName)}";
        }
    }
}