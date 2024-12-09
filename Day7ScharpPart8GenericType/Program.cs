namespace Day7ScharpPart8GenericType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Employee> Employees = new List<Employee>();
            List<string> Name = new List<string>();
            List<int> Numbers = new List<int>();
            Numbers.Add(100);

            //--- string --- class
            ClassInApplication<string> C = new ClassInApplication<string>();
            C.Save("Test");
            Console.WriteLine(C.GetName());

            //--- Double --- struct
            ClassInApplication<double> D = new ClassInApplication<double>();
            D.Save(1.25);
            Console.WriteLine(D.GetName());

            //--- Employee --- class
            ClassInApplication<Employee> Emp = new ClassInApplication<Employee>();
            Emp.Save(Emp.Name);
            Console.WriteLine(Emp.GetName());

            Console.ReadLine();

        }
    }

    //Generic Class 
    public class ClassInApplication<T>  //where T:struct   OR where T : class
    {
        //Generic Property 
        public T Name { get; set; }
        public void Save(T name)  //Generic Parameter
        {
            Name = name;
        }
        // Generic Method 
        public T GetName()
        {
            return Name;
        }
    }

    public class Employee
    {
        public string FullName { get; set; }
    }
}
