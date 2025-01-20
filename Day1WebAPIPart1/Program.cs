namespace Day1WebAPIPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            classA ca = new classA("Test");
            Console.ReadLine();
        }
    }
    //OOP
    public class classA
    {
        //default ctor
        public classA() // : this("Welcome in WebApi ...")
        {

        }
        //Non-default CTOR (Oveload CTOR)
        public classA(string value)
        {
            Console.WriteLine(value);
        }

        public classA(int x, string name)
        {

        }
    }
}
