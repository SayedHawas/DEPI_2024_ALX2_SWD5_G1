namespace Day7CSharpPart1AbstarctClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Normal Class  (Static) Object & Inheritance From & To
                Sealed Class   Object & Inheritance To   
                static Class   (Con Not Content Non-Static Members) Can not Object &  Can not Inheritance From to  
                Partial Class   Object & Inheritance From & To 
                Abstract Class  Inheritance From Must Implement all Abstract Members
                                Inheritance To All
             */

            Console.WriteLine("Hello, World!");
            //AbstractClass Ac = new AbstractClass(); Error
        }
    }
    public class Employee : AbstractClass
    {
        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override double InCome()
        {
            return 15000;
        }
    }
    public class Doctor : AbstractClass
    {
        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override double InCome()
        {
            return 25000;
        }
    }
    public class FootballPlayer : AbstractClass
    {
        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override double InCome()
        {
            return 150000;
        }
    }
    public abstract class AbstractClass : test
    {
        //Abstract Member
        public abstract double InCome();

        public abstract string GetName();
        //Normal Method 
        //public double InCome()   //Signature
        //{ 
        //   //Body Method Implementing 
        //}
    }
    public class InheritanceTest : AbstractClass
    {
        public int ID { get; set; }

        public override string GetName()
        {
            throw new NotImplementedException();
        }

        public override double InCome()
        {
            throw new NotImplementedException();
        }
    }
    public class test
    {

    }
    public abstract class Person : AbstractClass
    {
        public abstract int GetAge();
    }
    public class Manager : Person
    {
        public override int GetAge()
        {
            throw new NotImplementedException();
        }
        public override string GetName()
        {
            throw new NotImplementedException();
        }
        public override double InCome()
        {
            throw new NotImplementedException();
        }
    }
    // Access-Modifier Public - Private 
    public abstract class OperationCRUD   //0 To 100 %
    {
        //Normal Method 
        //public int getID()
        //{
        //    return 1;
        //}

        //Abstract Method 
        public abstract void Insert();
        public abstract void Update();
        public abstract void Delete();
        public abstract void GetAll();
        public abstract void GetByID(int Id);
    }
    public class NewEmployee : OperationCRUD
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public override void Insert()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    public class NewManager : OperationCRUD
    {
        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void GetAll()
        {
            throw new NotImplementedException();
        }

        public override void GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public override void Insert()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    //------------------ Override  AND Abstract
    public class testOverride
    {
        public virtual void Save()
        {
            Console.WriteLine("Save From Base testOverride ... ");
        }
    }
    public abstract class testAbstract
    {
        public abstract void Save();

    }
    public class testTwo : testOverride
    {
        public override void Save()
        {
            base.Save();
        }
    }
    public class testThree : testAbstract
    {
        public override void Save()
        {

        }
    }

    //---------------------------- NEW (Polymorphism)
    public class Product
    {
        public virtual double getPrice()
        {
            return 100;
        }
    }
    public class Labtop : Product
    {
        public override double getPrice()
        {
            return base.getPrice() + 20000;
        }
    }
    public class IMac : Labtop
    {
        public new double getPrice() //NEW Create New Object & Stop Override 
        {
            return base.getPrice() + 60000;
        }
    }
    public class Galaxy : IMac
    {
        //override
        //public override double getPrice()
        //{
        //    return base.getPrice();
        //}
    }
}
