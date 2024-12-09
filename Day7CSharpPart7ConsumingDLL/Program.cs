using Day7CSharpPart6DLL;

namespace Day7CSharpPart7ConsumingDLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee();
            Console.WriteLine(emp.Sum(10, 5));

            TestAccessModifier TAM = new TestAccessModifier();
            TAM.PublicItem = 10;
            //TAM.protectedItem NO
            //TAM.PrivateProtectedItem  NO
            //TAM.InternalItem  NO;
            //TAM.PrivateItem   NO;
            //TAM.InternalProtectedItem NO
            Console.ReadLine();

        }
    }

    public class Test : TestAccessModifier
    {
        public Test()
        {
            PublicItem = 10;
            protectedItem = 50;
            InternalProtectedItem = 100;
            //PrivateProtectedItem  NO;
            //InternalItem = 30;    NO
            //PrivateItem =10;      NO;

        }
    }
}
