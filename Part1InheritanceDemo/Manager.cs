namespace Part1InheritanceDemo
{
    public class Manager : Employee //: Person 
    {
        public string DepsrtmentManager { get; set; }

        public override string Info()
        {
            return base.Info() + $"My Department is {DepsrtmentManager}";
        }

        public double NetSalary(double OverTime, double tax, double bouns)
        {
            return Salary + OverTime - tax + bouns;
        }
    }
}
