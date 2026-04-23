namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static Plane Boeing = new Plane("Boing", 150, new DateTime(2015, 2, 3));
        public static Plane Airbus = new Plane("Airbus", 250, new DateTime(2020, 11, 11));

        public static Staff Captain = new Staff(
            "captain", "captain", "Captain.captain@gmail.com",
            new DateTime(1965, 1, 1), new DateTime(1999, 1, 1), 99999);

        public static Staff Hostess1 = new Staff(
            "hostess1", "hostess1", "hostess1.hostess1@gmail.com",
            new DateTime(1995, 1, 1), new DateTime(2020, 1, 1), 999);

        public static Staff Hostess2 = new Staff(
            "hostess2", "hostess2", "hostess2.hostess2@gmail.com",
            new DateTime(1996, 1, 1), new DateTime(2020, 1, 1), 999);

        public static Traveller Traveller1 = new Traveller(
            "Traveller1", "Traveller1", "Traveller1.Traveller1@gmail.com",
            new DateTime(1980, 1, 1), "No troubles", "American");

        public static Traveller Traveller2 = new Traveller(
            "Traveller2", "Traveller2", "Traveller2.Traveller2@gmail.com",
            new DateTime(1981, 1, 1), "Some troubles", "French");

        public static Traveller Traveller3 = new Traveller(
            "Traveller3", "Traveller3", "Traveller3.Traveller3@gmail.com",
            new DateTime(1982, 1, 1), "No troubles", "Tunisian");

        public static Traveller Traveller4 = new Traveller(
            "Traveller4", "Traveller4", "Traveller4.Traveller4@gmail.com",
            new DateTime(1983, 1, 1), "Some troubles", "American");

        public static Traveller Traveller5 = new Traveller(
            "Traveller5", "Traveller5", "Traveller5.Traveller5@gmail.com",
            new DateTime(1984, 1, 1), "Some troubles", "Spanish");

        public static List<Flight> listFlights = new List<Flight>
        {
            new Flight(
                new DateTime(2022, 1, 1, 15, 10, 10), "Paris",
                new DateTime(2022, 1, 1, 17, 10, 10), Airbus, 110)
            {
                Passengers = new List<Passenger>
                    { Traveller1, Traveller2, Traveller3, Traveller4, Traveller5,
                      Captain, Hostess1, Hostess2 }
            },
            new Flight(
                new DateTime(2022, 2, 1, 21, 10, 10), "Paris",
                new DateTime(2022, 2, 1, 23, 10, 10), Boeing, 105),
            new Flight(
                new DateTime(2022, 3, 1,  5, 10, 10), "Paris",
                new DateTime(2022, 3, 1,  6, 40, 10), Boeing, 100),
            new Flight(
                new DateTime(2022, 4, 1,  6, 10, 10), "Madrid",
                new DateTime(2022, 4, 1,  8, 10, 10), Boeing, 130),
            new Flight(
                new DateTime(2022, 5, 1, 17, 10, 10), "Madrid",
                new DateTime(2022, 5, 1, 18, 50, 10), Boeing, 105),
            new Flight(
                new DateTime(2022, 6, 1, 20, 10, 10), "Lisbonne",
                new DateTime(2022, 6, 1, 22, 30, 10), Airbus, 200),
        };
    }
}