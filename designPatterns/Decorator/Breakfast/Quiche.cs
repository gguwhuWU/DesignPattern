namespace designPatterns.Decorator.Breakfast
{
    public class Quiche : IBreakfast
    {
        public string description
        {
            get
            {
                return "蛋餅";
            }
        }

        public dynamic GetCost()
        {
            return (dynamic)25;
        }

        public string GetDescription()
        {
            return this.description;
        }
    }
}
