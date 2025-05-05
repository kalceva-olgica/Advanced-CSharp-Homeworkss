namespace task04
{
   public abstract class Employee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
