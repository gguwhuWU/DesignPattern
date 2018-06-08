namespace designPatterns.Decorator.CondimentDecorator
{
    public class Lettuce : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Lettuce(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "生菜";
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
