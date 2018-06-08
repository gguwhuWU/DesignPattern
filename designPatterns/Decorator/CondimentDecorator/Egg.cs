namespace designPatterns.Decorator.CondimentDecorator
{
    public class Egg : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Egg(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "蛋";
            }
        }

        public dynamic GetCost()
        {
            return breakfast.GetCost() + 10;
        }

        public string GetDescription()
        {
            return $"{breakfast.GetDescription()}, {this.description}";
        }
    }
}
