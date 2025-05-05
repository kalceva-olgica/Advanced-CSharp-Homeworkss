namespace task04
{
   public class Programmer : Employee
    {
        public int workingHours { get; set; }
        public double rateHour { get; set; }

        public Programmer(string name, int hoursWorked, double hourlyRate)
        {
            Name = name;
            workingHours = hoursWorked;
            rateHour = hourlyRate;
        }

        public override double CalculateSalary()
        {
            return workingHours * rateHour;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name}, Salary: {CalculateSalary()}");
        }
    }
}
