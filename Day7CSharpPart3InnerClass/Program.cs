namespace Day7CSharpPart3InnerClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Create Object 
            OuterClass.InnerClass IC = new OuterClass.InnerClass();

            OuterClass OC = new OuterClass();

        }
    }

    public class OuterClass
    {

        public class InnerClass
        {

        }
    }
}
