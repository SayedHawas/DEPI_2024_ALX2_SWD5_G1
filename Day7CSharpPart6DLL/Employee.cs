namespace Day7CSharpPart6DLL
{
    //Object 
    public class Employee
    {
        public Employee()
        {
            //Object 
            TestAccessModifier TAM = new TestAccessModifier();
            TAM.PublicItem = 10;
            TAM.InternalItem = 20;
            TAM.InternalProtectedItem = 30;  //Internal
            //TAM.PrivateItem //NO;
            //TAM.ProtectedItem //NO
        }
        public double Sum(double x, double y)
        {
            return x + y;
        }

    }
    //Inheritance
    public class TestInheritance : TestAccessModifier
    {
        public TestInheritance()
        {
            protectedItem = 10; //Inheritance
            PrivateProtectedItem = 20;
            PublicItem = 30;
            //TAM.InternalItem  NO;
            //TAM.PrivateItem   NO;


        }
    }
    public class TestAccessModifier
    {
        /*
          public: Code in any assembly can access this type or member. The accessibility level of the containing type controls the accessibility level of public members of the type.
          private: Only code declared in the same class or struct can access this member.
          protected: Only code in the same class or in a derived class can access this type or member.
          internal: Only code in the same assembly can access this type or member.
          protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
          private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.
         */
        // Object & Inheritance  
        private int PrivateItem { get; set; }
        public int PublicItem { get; set; }
        internal int InternalItem { get; set; }
        protected int protectedItem { get; set; }
        internal protected int InternalProtectedItem { get; set; }
        private protected int PrivateProtectedItem { get; set; }
    }
}
