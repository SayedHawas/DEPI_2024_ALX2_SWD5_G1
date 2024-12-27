namespace Day10CSharpCTORInhertPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DbConnection dbc1 = new DbConnection();

            //Connection c = new Connection("Sayed");

            // DbConnection dbc = new DbConnection("Sayed");

            //DbConnection dbc1 = new DbConnection("Sayed", "Alex");

            Console.ReadLine();
        }
    }

    public class Connection
    {
        //Default - CTOR
        public Connection()
        {
            Console.WriteLine("Print form Supper Class ");
        }
        //Non-Default CTOR  -- OverLoading 
        public Connection(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
        public Connection(string name, string location)
        {
            Console.WriteLine($"Welcome {name} And Location is {location}");
        }
        //this
    }

    public class DbConnection : Connection
    {
        public DbConnection() : base()
        {
            Console.WriteLine("Print form Sub Class ");
        }
        //this  in the class 
        //base With Inhrit Refer -->  Supper Class 
        public DbConnection(string dbStringName) : base(dbStringName)
        {

        }
        public DbConnection(string dbStringName, string Location) : base(dbStringName, Location)
        {

        }
    }
}
