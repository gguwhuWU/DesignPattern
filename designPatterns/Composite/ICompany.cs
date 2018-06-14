namespace designPatterns.Composite
{
    public interface ICompany
    {
        string Name { get; }
        void Add(ICompany c);
        void Remove(ICompany c);
        void Display(int depth);
        void DoWork();
    }
}
