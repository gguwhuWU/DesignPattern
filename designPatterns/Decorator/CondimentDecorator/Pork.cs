namespace designPatterns.Decorator.CondimentDecorator
{
    public class Pork : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Pork(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "豬肉";
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
