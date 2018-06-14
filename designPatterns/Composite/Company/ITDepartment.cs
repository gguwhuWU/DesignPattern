using System;

namespace designPatterns.Composite.Company
{
    public class ITDepartment : AbstractCompany
    {
        public ITDepartment(string name) : base(name)
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
            Console.WriteLine($"{Name}: 資訊軟體建立與維護!");
        }

        public override void Remove(ICompany c)
        {
        }
    }
}
