namespace Day7CSharpPart2Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public abstract class Person
    {
        public int ID { get; set; }          //Normal 
        public string Name { get; set; }     //Normal
        public abstract void SayName();
    }
    //Type Interface
    //Muit-Inheritance   Cannot
    //Muit-Implementing  Can (Interface)  --> API Over Http Interface (Contract)
    public class Employee : Person, IOperatorCURD, IConnectionWithDatabase
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }
        public string GetDatabase()
        {
            throw new NotImplementedException();
        }
        public void Insert()
        {
            throw new NotImplementedException();
        }
        public virtual void Read()
        {
            throw new NotImplementedException();
        }
        public void ReadByID()
        {
            throw new NotImplementedException();
        }
        public override void SayName()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    public class Manager : Employee //,IOperatorCURD
    {
        public override void Read()
        {
            base.Read();
        }
        public override void SayName()
        {
            base.SayName();
        }
    }
    public class Test
    {

    }
}
