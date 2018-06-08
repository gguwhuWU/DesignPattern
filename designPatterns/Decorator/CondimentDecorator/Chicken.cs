namespace designPatterns.Decorator.CondimentDecorator
{
    public class Chicken : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Chicken(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "雞肉";
            }
        }

        public dynamic GetCost()
        {
            return breakfast.GetCost() + 20;
        }

        public string GetDescription()
        {
            return $"{breakfast.GetDescription()}, {this.description}";
        }
    }
}
