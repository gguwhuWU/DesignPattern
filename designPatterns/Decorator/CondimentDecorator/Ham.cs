namespace designPatterns.Decorator.CondimentDecorator
{
    public class Ham : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Ham(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "火腿";
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
