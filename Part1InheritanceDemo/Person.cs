namespace Part1InheritanceDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        //Poly  Override
        public virtual string Info()  //--->signture 
        {
            return $"My Name is {Name} And My Age is {Age} & My city is {City}";  //Body
        }
    }
}
