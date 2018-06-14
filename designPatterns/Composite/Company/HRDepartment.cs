using System;

namespace designPatterns.Composite.Company
{
    public class HRDepartment : AbstractCompany
    {
        public HRDepartment(string name) : base(name)
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
            Console.WriteLine($"{Name}: 員工招聘與訓練!");
        }

        public override void Remove(ICompany c)
        {
        }
    }
}
