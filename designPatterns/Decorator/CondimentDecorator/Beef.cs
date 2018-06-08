namespace designPatterns.Decorator.CondimentDecorator
{
    public class Beef : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Beef(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "牛肉";
            }
        }

        public dynamic GetCost()
        {
            return breakfast.GetCost() + 25;
        }

        public string GetDescription()
        {
            return $"{breakfast.GetDescription()}, {this.description}";
        }
    }
}
