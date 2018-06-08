namespace designPatterns.Decorator.CondimentDecorator
{
    public class Cheese : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Cheese(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "起司";
            }
        }

        public dynamic GetCost()
        {
            return breakfast.GetCost() + 5;
        }

        public string GetDescription()
        {
            return $"{breakfast.GetDescription()}, {this.description}";
        }
    }
}
