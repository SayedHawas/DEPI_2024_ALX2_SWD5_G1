namespace Part1InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome in C# With Github");
            Console.WriteLine("Hello");
            //---------------------------------------------
            Employee ahmed = new Employee();

            ahmed.Id = 5;
            ahmed.Name = "Ahmed Ali ";
            ahmed.Salary = 10000;
            ahmed.Age = 25;
            ahmed.City = "Alex";
            //ahmed.NetSalary()

            ahmed.Add(ahmed);
            ahmed.Add(new Employee() { Id = 2, Name = "Ali", Salary = 500 });
            Employee tammer = new Employee { Id = 1, Name = "tammer Ali", Salary = 15000 };
            tammer.Add(tammer);
            foreach (var emp in Employee.employees)
            {
                Console.WriteLine(emp.Info());
            }

            /////////////////////////////////////////////////
            Manager retaj = new Manager();
            retaj.Id = 3;
            retaj.Name = "Retaj Elsayed";
            retaj.Salary = 25000;
            retaj.Age = 25;
            retaj.DepsrtmentManager = "Software";
            retaj.City = "Cairo";
            // retaj.NetSalary()
            Console.WriteLine(retaj.Info());

            Console.ReadLine();
        }
    }
}
