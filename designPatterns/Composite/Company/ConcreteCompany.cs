using System;
using System.Collections.Generic;

namespace designPatterns.Composite.Company
{
    public class ConcreteCompany : AbstractCompany
    {
        private List<ICompany> children;

        public ConcreteCompany(string name) : base(name)
        {
            children = new List<ICompany>();
        }

        public override void Add(ICompany c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (ICompany component in children)
            {
                component.Display(depth + 2);
            }
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name}:做事情!");

            foreach (ICompany component in children)
            {
                component.DoWork();
            }
        }

        public override void Remove(ICompany c)
        {
            children.Remove(c);
        }
    }
}
