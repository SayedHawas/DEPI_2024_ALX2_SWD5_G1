namespace Day10CSharpPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Program P = new Program();
            P.sum();

            //Polymorphism
            // OverLoad --> Class 
            // Override --> Inhritance 
        }

        public void sum()
        {

        }
        public void sum(int x, int y)
        {

        }
        public int sum(int x, int y, int z)
        {
            return x + y;
        }
    }
    public class Human
    {
        public virtual int GetAge()
        {
            return 10;
        }
    }
    public class Man : Human
    {
        public override int GetAge()
        {
            //return base.GetAge();
            return 20;
        }
    }
    public class Employee : Man
    {
        public new int GetAge()
        {
            return base.GetAge();
        }
    }
    //--------------------------------------------------
    public class Manager : Employee
    {
        public int GetAge()
        {
            return base.GetAge() + 100;
        }
    }
    public class TopManager : Manager
    {
        public int GetAge()
        {
            return base.GetAge();
        }
    }





}
