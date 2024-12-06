namespace Part1InheritanceDemo
{

    public class Employee : Person
    {
        //Class Members
        //StaticMember //Table in Database 
        public static List<Employee> employees = new List<Employee>();
        //Fields 
        public int Id { get; set; }
        public double Salary { get; set; }
        //default CTOR
        //OverLoad CTOR
        public Employee()
        {

        }
        //Non-Default CTOR
        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            Name = name;
            Salary = salary;
        }
        // Type  --->  Data Type
        //Method Comment 
        /// <summary>
        ///  This Method To add Employee To static List Employees
        /// </summary>
        /// <param name="newEmployee"> the New Object From Class Employees </param>
        public void Add(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }
        //public string Info()
        //{
        //    return $"this Employee is {Name} with Id = {Id} & Salary : {Salary}";
        //}
        //Base Class 
        public override string Info()
        {
            // return base.Info() + $" and {Name} with Id = {Id} & Salary : {Salary}  ";
            return $"this Employee is {Name} with Id = {Id} & Salary : {Salary} And City {City} And Age {Age}  ";
        }
        //Ploy OverLoad
        public double NetSalary()
        {
            return Salary;
        }
        public double NetSalary(double OverTime)
        {
            return Salary + OverTime;
        }
        public double NetSalary(double OverTime, double tax)
        {
            return Salary + OverTime - tax;
        }
    }
}
