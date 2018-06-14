using System;

namespace designPatterns.Composite.Company
{
    public class FinanceDepartment : AbstractCompany
    {
        public FinanceDepartment(string name) : base(name)
        {
        }

        public override void Add(ICompany c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name}: 財務收支管理!");
        }

        public override void Remove(ICompany c)
        {
        }
    }
}
