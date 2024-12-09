namespace Day7CsharpPart5Enum
{
    //Create Enum  Base INT Value
    public enum SalaryTypes
    {
        FullTime = 0,
        PartTime,
        FreeLace,
        PerProject
    }
    public enum EmployeeType
    {
        Employee,
        Manager
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Number = new List<int>();
            Number.Add(10);
            Console.WriteLine("Hello, World!");

            Employee ahmed = new Employee();
            ahmed.ID = 1;
            ahmed.Name = "Ahmed Ali";
            ahmed.Type = EmployeeType.Employee;
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EmployeeType Type { get; set; }

        public double NetSalary(EmployeeType employeeType)
        {
            double result = 0;
            switch (employeeType)
            {
                case EmployeeType.Employee:
                    result = 5000d;
                    break;
                case EmployeeType.Manager:
                    result = 10000d;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        public double NetSalary(SalaryTypes salaryType)
        {
            switch (salaryType)
            {
                case SalaryTypes.FullTime:
                    break;
                case SalaryTypes.PartTime:
                    break;
                case SalaryTypes.FreeLace:
                    break;
                case SalaryTypes.PerProject:
                    break;
            }
            return 0;
        }
    }
}