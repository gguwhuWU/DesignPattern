namespace designPatterns.Visitor
{
    public interface IPerson
    {
        void Accept(IAction visitor);
    }
}
