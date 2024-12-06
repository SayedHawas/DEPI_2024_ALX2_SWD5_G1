namespace Part2ClassOfTypesDmeo
{

    //class Number : Int32
    //{ 

    //}
    internal class Program
    {
        //Day 6 in C# 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 5;
            x.Add(100);
            Console.WriteLine(x.Add(100));

            string name = "Ahmed Ali";
            Console.WriteLine(name.NewTruncate());
            string FullName = "Sayed Said AbdelRahman Hawas";
            Console.WriteLine(FullName.NewTruncate());
            Console.ReadLine();
            /*
                Normal Class  (Static) Object & Inheritance From & To
                Sealed Class   Object & Inheritance To   
                static Class   (Con Not Content Non-Static Members) Can not Object &  Can not Inheritance From to  
                Partial Class    
                Abstract Class 
             */

            NormalClass Nc = new NormalClass();
            Nc.ID = 1;
            NormalClass.SayHello();

            SealedClass Sc = new SealedClass();
            Sc.ID = 2;

            //create Object From static Class  Error 
            // StaticClass stic = new StaticClass();


            PartialClass Pc = new PartialClass();
            Pc.Name = "Ahmed";
        }
    }

    public class InheritanceTest
    {
        public int ID { get; set; }
    }
    public class NormalClass : InheritanceTest
    {
        public static string SayHello()
        {
            return "Hello";
        }
    }

    public class test  //: StaticClass //: NormalClass   //:SealedClass Error 
    {

    }
    public sealed class SealedClass : InheritanceTest
    {

    }

    public static class StaticClass //:InheritanceTest
    {

    }

    //Extension Method 
    //Common Use Without Object Or Instance 
    public static class NewInteger
    {
        public static int Add(this int x, int y)
        {
            return x + y;
        }

    }

    public static class NewString
    {
        public static string NewTruncate(this string name)
        {
            if (name.Length > 20)
            {
                return name.Substring(0, 20) + "...";
            }
            return name;
        }
    }

    public partial class PartialClass
    {
        public int Id { get; set; }
    }
    public partial class PartialClass
    {
        public string Name { get; set; }
    }
    public partial class PartialClass
    {
        public string Job { get; set; }
    }
}
