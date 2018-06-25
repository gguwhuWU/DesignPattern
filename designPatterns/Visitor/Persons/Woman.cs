namespace designPatterns.Visitor.Persons
{
    public class Woman : IPerson
    {
        public void Accept(IAction visitor)
        {
            visitor.ShowWomanConclusion(this);
        }
    }
}
