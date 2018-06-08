using System.Text;

namespace designPatterns.Decorator
{
    public interface IBreakfast
    {
        string description { get; }
        string GetDescription();
        dynamic GetCost();
    }
}
