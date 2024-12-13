namespace Day8CsharpPart1LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             LINQ Principles:-
                ------------------
                1)Implicit type (Var)     Done 
                2)Object Initializer.     Done 
              2.2) Anonymous Object.      Done
                3)Collection Initializer. Done
                4)Dynamic Name.           Done
                5)Anonymous Types.              Done
                6)Generic type.                 Done
                7)Extension Methods.            Done 
            
                8)Delegate.                     Done  
                9)Linq To Object (Linq Query).  Done 
                10)Anonymous Delegate.          Done
                11)Anonymous Method.            Done
                12)Linq Lambda Expression.      Done 
                13)Built-in Delegate.           Done
                *****************************
                14) Into To Delegate & Event.
                15) IEnumerable vs IQueryable.
             */
            Console.WriteLine("Hello, World!");
            //LINQ To Object Collection 
            List<string> Names = new List<string>();
            Names.Add("Ahmed"); //0
            Names.Add("Sayed"); //1
            Names.Add("Retaj"); //2  INDEX   =  ID Table 

            Console.WriteLine(Names[1]);

            // Get start with R 
            foreach (var name in Names)
            {
                if (name.StartsWith("R"))
                {
                    Console.WriteLine(name);
                }
            }
            //Object 
            //LINQ To Object (Collection)
            var setectone = Names.Where(n => n.StartsWith("R")).First();
            Console.WriteLine(setectone);

            Employee empAhmed = new Employee();
            empAhmed.ID = 5;
            empAhmed.Name = "Ahmed";


            //Object Initializer (Can not Create Without Default CTOR)
            Employee emp = new Employee() { ID = 1, Name = "Ahmed" };

            //Anonymous Object
            new Employee();

            //Collection Initializer.
            //Type Can be DataType
            List<Employee> Employees = new List<Employee>();
            Employees.Add(emp);                      //Index 0
            Employees.Add(new Employee() { ID = 2, Name = "Tamer" }); //On Fly    //Index 1



            Employee emp1 = new Employee();
            emp1.ID = 3;
            emp1.Name = "Yasser";

            Employees.Add(emp1);


            List<Employee> Employeess = new List<Employee>() {
            new Employee() { ID = 1, Name = "Ahmed" },
            new Employee() { ID = 2, Name = "Sayed" },
            new Employee() { ID = 3, Name = "Ali" },
            new Employee() { ID = 4, Name = "Ahmed" },
            };

            //Collection LINQ To Object 

            //Lambda Expression 
            var result = Employeess.Where(e => e.Name.Contains("S") && e.ID == 2).First();
            Console.WriteLine($"ID :{result.ID} Name : {result.Name} ");

            Console.WriteLine("------------------------");
            //Sugar Expression  SQL Query 
            //4)Dynamic Name.
            var resultQuery = from emps in Employeess
                              where emps.Name == "Ahmed" || emps.ID == 1
                              select emps;  //All Properties | Object Of Employee

            foreach (var item in resultQuery)
            {
                Console.WriteLine($" {item.ID} {item.Name}");
            }
            //-------------------------------------------------------------
            //5)Anonymous Types. FOR READ ONLY 
            var Student = new { ID = 1, Name = "Ahmed", Job = "Developer" };

            Console.WriteLine(Student.ID);
            //Student.ID = 7; Error
            var resultQuery2 = from emps in Employeess
                               where emps.Name == "Ahmed" || emps.ID == 1
                               select new { Code = emps.ID, FullName = emps.Name };

            //IEnumerable<>

            foreach (var item in resultQuery2)
            {
                Console.WriteLine($" {item.Code} {item.FullName}");
            }

            //--------------------------------------------------------------
            Employee E = new Employee { ID = 1, Name = "Labtop" };
            Product P = new Product() { ID = 1, Name = "Labtop", UnitPrice = 30000 };

            MyList<Employee> ListOfEmployee = new MyList<Employee>();
            ListOfEmployee.Add(E);

            MyList<Product> ListOfProducts = new MyList<Product>();
            ListOfProducts.Add(P);
            //------------------------------------------------------
            // 7)Extension Methods.
            List<Product> NewProducts = new List<Product>();

            var output = NewProducts.FirstOrDefault(p => p.ID == 1);

            Console.ReadLine();
        }
    }

    //Type Refere Class
    public class Employee
    {
        //CTOR Default 
        public Employee()
        {

        }
        // OverLoad CTOR NON-default
        public Employee(int id, string name)
        {

        }
        public int ID { get; set; }
        public string Name { get; set; }
    }

    // Mapping   ORM Object Relational Mapping 
    // Each Table  Covert To Class
    // Row  Object From Class 
    // table Collection from Class  
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }

    public class MyList<T>
    {
        static List<T> Items = new List<T>();

        public void Add(T item)
        {
            Items.Add(item);
        }
    }
}
