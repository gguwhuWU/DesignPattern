namespace designPatterns.Composite.Company
{
    public abstract class AbstractCompany : ICompany
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            protected set
            {
                name = value;
            }
        }

        public AbstractCompany(string name)
        {
            this.Name = name;
        }

        public abstract void Add(ICompany c);

        public abstract void Display(int depth);

        public abstract void DoWork();

        public abstract void Remove(ICompany c);
    }
}
