namespace challenge2
{
    //abstraction
    abstract class Employee
    {
        protected Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public abstract double CalculateSalary();
    }
    class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string name, double fixedSalary) : base(name)
        {
            {
                this.fixedSalary = fixedSalary;
            }
        }
        public double fixedSalary { get; set; }
        public override double CalculateSalary()
        {
            return fixedSalary;
        }
    }
    class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, double hoursWorked, double hourlyRate) : base(name)
        {
            {
                this.hoursWorked = hoursWorked;
                this.hourlyRate = hourlyRate;
            }
        }
        public double hoursWorked { get; set; }
        public double hourlyRate { get; set; }
        public override double CalculateSalary()
        {
           return hoursWorked *hourlyRate;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee fulltimeemployee = new FullTimeEmployee("omar", 5003);
            Employee parteimeemployee = new PartTimeEmployee("merna", 23, 100);
           Console.WriteLine( fulltimeemployee.CalculateSalary());
             Console.WriteLine( parteimeemployee.CalculateSalary());
        }
    }
}
