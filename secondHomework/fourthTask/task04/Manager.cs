namespace task04
{
   public class Manager : Employee  
    {
        public double BaseSalary { get; set; }

        public Manager(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + 2000; 
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, Salary: {CalculateSalary()}");
        }
    }
}
