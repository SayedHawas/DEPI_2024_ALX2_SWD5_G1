namespace Day8CSharpPart3Fun_Action_pred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //----------------------------------------------------------------
            //-- < Delegate Type > Identifier = (< Param List >) => < Expression > --
            //----------------------------------------------------------------
            //            *) Delegate Type Like: (Func, Action, Predicate)
            //*) Delegate is the Pointer to Method

            //Delegate Type Like: -
            //---------------------
            //             -Func      : deleget Which return One Value.              16 Input parameters  With Return(Function) 17 Output
            //             - Func<int, int> increment = i => i + 1;

            //            -Action    : delegate which not return Value.             16 Input parameters Without Return(Void)
            //             -Action<int> d = x => Console.WriteLine(x);

            //            -Predicate : delegate which return bool only.

            //            - predicate<int> cc = c => true; 1 Input parameters With Return(True Or False)

            //Func<int, int, int> test = delegate (int x, int y) { return x + y; };

            //return 
            Func<int, int, int> test = (x, y) => x + y;
            //Action<string> SayHello = delegate (string strName) { Console.WriteLine("Hello " + strName); };

            //Void 
            Action<string> SayHello = strName => Console.WriteLine("Hello " + strName);
            SayHello("Sayed Hawas");

            int Total = test(10, 20);
            Console.WriteLine(Total);

            // Predicate<int> CheckSalary = delegate (int salary) { return salary > 5000; };

            Predicate<int> CheckSalary = salary => salary > 5000;
            Console.WriteLine(CheckSalary(3000)); //false
            Console.WriteLine(CheckSalary(9000)); //true


            List<Employee> ListEmployees = new List<Employee>();
            ListEmployees.Add(new Employee { ID = 1, Name = "Retaj", Job = "Developer", Salary = 5000, Attend = true });
            ListEmployees.Add(new Employee { ID = 2, Name = "Mariam", Job = "Dr", Salary = 6000, Attend = true });
            ListEmployees.Add(new Employee { ID = 3, Name = "sayed", Job = "Developer", Salary = 3000, Attend = false });
            ListEmployees.Add(new Employee { ID = 4, Name = "osama", Job = "eng", Salary = 7000, Attend = true });

            var employeeList = ListEmployees.Where(e => e.Name.Contains("a"));

            foreach (Employee emp in employeeList)
            {
                Console.WriteLine($"the Id {emp.ID} name {emp.Name} salary {emp.Salary} job {emp.Job}");
            }

            var oneEmp = employeeList.FirstOrDefault(e => e.ID == 1);

            Console.WriteLine($"the Id {oneEmp.ID} name {oneEmp.Name} salary {oneEmp.Salary} job {oneEmp.Job}");
            Console.ReadLine();

        }
        public static int test2(int x, int y)
        {
            return x + y;
        }
    }

    public class Employee
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public string Job { get; internal set; }
        public int Salary { get; internal set; }
        public bool Attend { get; internal set; }
    }
}
