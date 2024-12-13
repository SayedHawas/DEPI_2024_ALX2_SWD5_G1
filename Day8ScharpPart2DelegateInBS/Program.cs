namespace Day8ScharpPart2DelegateInBS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Employee> ListEmployees = new List<Employee>();
            ListEmployees.Add(new Employee { ID = 1, Name = "Retaj", Job = "Developer", Salary = 5000, Attend = true });
            ListEmployees.Add(new Employee { ID = 2, Name = "Mariam", Job = "Dr", Salary = 6000, Attend = true });
            ListEmployees.Add(new Employee { ID = 3, Name = "sayed", Job = "Developer", Salary = 3000, Attend = false });
            ListEmployees.Add(new Employee { ID = 4, Name = "osama", Job = "eng", Salary = 7000, Attend = true });

            ////10)Anonymous Delegate.
            ////11)Anonymous Method. 

            //// Employee.Report(ListEmployees);
            ////IsConditional Conditi = new IsConditional(check); //Instance 
            //// Employee.Report(ListEmployees, Conditi);

            //Employee em = new Employee();                               //Normal Instance 
            //new Employee() { ID = 5 };                                   //Anonymous Object 
            //var x = new { ID = 1, Name = "tammer", Job = "Developer " }; //Anonymous Type

            ////Employee.Report(ListEmployees, delegate (Employee emp) { return emp.Salary < 5000; });
            ////Employee.Report(ListEmployees,(emp) =>  emp.Salary < 5000 );
            //Employee.Report(ListEmployees, w => w.Salary > 5000);

            IEnumerable<Employee> Result = ListEmployees.Where(x => x.ID > 2);
            foreach (Employee emp in Result)
            {
                Console.WriteLine($"the Id {emp.ID} name {emp.Name} salary {emp.Salary} job {emp.Job}");
            }

            Console.ReadLine();
        }

        // (Employee emp) { return emp.Salary< 5000; }

        //Liner Method 
        //public static bool check(Employee emp)
        //{
        //    //return emp.Salary > 6000;
        //    //return emp.Attend == false;
        //    return emp.Name.StartsWith("M");
        //}
    }
    //public delegate bool IsConditional(Employee emp);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public bool Attend { get; set; }

        //public static void Report(List<Employee> employeeList, IsConditional condition)
        //{
        //    foreach (Employee emp in employeeList)
        //    {
        //        //Hard code
        //        //if (emp.Salary > 4000)
        //        //if (emp.Attend == true)
        //        if (condition(emp))
        //        {
        //            Console.WriteLine($"the Id {emp.ID} name {emp.Name} salary {emp.Salary} job {emp.Job}");
        //        }
        //    }
        //}
    }
}
