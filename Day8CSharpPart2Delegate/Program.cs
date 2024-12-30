namespace Day8CSharpPart2Delegate
{
    internal class Program
    {
        //Class Member Delegate  Fields , Prop , Method , CTOR , Delegate 

        //How to create Delegate 
        public delegate void SayHelloHandler(string x);

        //Type Can Be DataType 
        public delegate bool Mydeleget(int value);

        static void Main(string[] args)
        {
            Console.WriteLine(" Delegate .... ");
            /*
            8)Delegate: -
            ***************
            *Event Later
                Delegates are used as pointers to methods that handle events
                 /*
                  - Delegates is A Function Pointer
                  - Delegate  is a type safe Function
                  - Delegate  is Reference type (Heap) Class , string , Interface , Collection 
                  - the Signature of Delegate Must Match the Signature Of Function Pointed it. 
               
                 * To Link Action   ----> Delegate  ----->Event
                 * To Do Event      ----call----->Delegate------ - Point To------ > Action
            *
            */
            //Instance Of delegate 
            SayHelloHandler S = new SayHelloHandler(SayHello);
            S("Ahmed");




            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            CheckNumber(num => num > 5, numbers);
            Console.WriteLine("---------------------");
            Console.WriteLine("Even numbers");

            //This Method Linner To Delegate 
            CheckNumber(x => x % 2 == 0, numbers);
            Console.WriteLine("Odd numbers");
            CheckNumber(x => x % 2 == 1, numbers);










            //Console.WriteLine("Even numbers");
            //CheckNumber(x => x % 2 == 0, numbers);
            //Console.WriteLine("Odd numbers");
            //CheckNumber(x => x % 2 == 1, numbers);


            Console.ReadLine();
        }


        //
        public static bool checkMethod(int x)
        {
            return x % 2 == 0;
        }


        //Method 
        public static void SayHello(string Name)
        {
            Console.WriteLine("Hello " + Name);
        }
        //VIP* Pass Delegate As Parameters
        public static void CheckNumber(Mydeleget Check, int[] array)
        {
            foreach (var item in array)
            {
                //if (item >= 5)//condition  Hard Code
                if (Check(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
