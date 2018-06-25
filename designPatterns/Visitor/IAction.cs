using designPatterns.Visitor.Persons;

namespace designPatterns.Visitor
{
    public interface IAction
    {
        void ShowManConclusion(Man element);
        void ShowWomanConclusion(Woman element);
    }
}
