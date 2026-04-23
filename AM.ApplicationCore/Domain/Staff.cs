namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }

        public Staff(string firstName, string lastName, string email,
                     DateTime birthDate, DateTime employmentDate, double salary)
            : base(firstName, lastName, email, birthDate)
        {
            EmploymentDate = employmentDate;
            Salary = salary;
        }

        public override string ToString() =>
            $"[Staff] {FirstName} {LastName}, Email={EmailAddress}, Salary={Salary}";
    }
}