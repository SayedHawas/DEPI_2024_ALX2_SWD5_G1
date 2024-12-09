namespace Day7CSharpPart4EnumStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Address MyAddress = new Address();
            MyAddress.Country = "Egypt";
            MyAddress.City = "Alex";
            MyAddress.Area = "Sidi gaber";
            MyAddress.Street = "ElMosheer";

            Console.WriteLine(MyAddress.FullAddress());
            //----------------------------------------------
            // Create an instance of MyClass
            MyClass classInstance1 = new MyClass(10);
            MyClass classInstance2 = classInstance1;

            // Modify classInstance2
            classInstance2.Value = 20;

            Console.WriteLine("Class:");
            Console.WriteLine($"classInstance1.Value: {classInstance1.Value}"); // Output: 20
            Console.WriteLine($"classInstance2.Value: {classInstance2.Value}"); // Output: 20

            // Create an instance of MyStruct
            MyStruct structInstance1 = new MyStruct(10);
            MyStruct structInstance2 = structInstance1;

            // Modify structInstance2
            structInstance2.Value = 20;

            Console.WriteLine("Struct:");
            Console.WriteLine($"structInstance1.Value: {structInstance1.Value}"); // Output: 10
            Console.WriteLine($"structInstance2.Value: {structInstance2.Value}"); // Output: 20
            Console.ReadLine();

        }
    }

    //Class  Refer
    public class TestClass
    {


    }
    public struct Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Area { get; set; }

        public string FullAddress()
        {
            return $"Country {Country} City {City} Area {Area} Street {Street}";
        }

    }

    // Define a class
    public class MyClass
    {
        public int Value { get; set; }

        public MyClass(int value)
        {
            Value = value;
        }
    }
    // Define a struct
    public struct MyStruct
    {
        public int Value { get; set; }

        public MyStruct(int value)
        {
            Value = value;
        }
    }



}
