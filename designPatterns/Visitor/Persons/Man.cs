namespace designPatterns.Visitor.Persons
{
    public class Man : IPerson
    {
        public void Accept(IAction visitor)
        {
            visitor.ShowManConclusion(this);
        }
    }
}
