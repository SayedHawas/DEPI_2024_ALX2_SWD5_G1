namespace Day7CSharpPart2Interface
{
    public interface IOperatorCURD  //100%
    {
        void Insert();
        void Update();
        void Delete();
        void Read();
        void ReadByID();
    }
    public interface IConnectionWithDatabase
    {
        string GetDatabase();
    }
}
