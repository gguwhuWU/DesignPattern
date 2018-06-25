using designPatterns.Visitor.Persons;
using System;

namespace designPatterns.Visitor.Actions
{
    public class Fail : IAction
    {
        public void ShowManConclusion(Man element)
        {
            Console.WriteLine($"失敗的{element.GetType().Name}");
        }

        public void ShowWomanConclusion(Woman element)
        {
            Console.WriteLine($"失敗的{element.GetType().Name}");
        }
    }
}
