using designPatterns.Visitor.Persons;
using System;

namespace designPatterns.Visitor.Actions
{
    public class Success : IAction
    {
        public void ShowManConclusion(Man element)
        {
            Console.WriteLine($"成功的{element.GetType().Name}");
        }

        public void ShowWomanConclusion(Woman element)
        {
            Console.WriteLine($"成功的{element.GetType().Name}");
        }
    }
}
