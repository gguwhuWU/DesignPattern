namespace designPatterns.Decorator.CondimentDecorator
{
    public class Corn : ICondimentDecorator
    {
        IBreakfast breakfast;
        public Corn(IBreakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public string description
        {
            get
            {
                return "玉米";
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
