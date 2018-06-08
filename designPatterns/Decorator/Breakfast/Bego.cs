namespace designPatterns.Decorator.Breakfast
{
    public class Bego : IBreakfast
    {
        public string description
        {
            get
            {
                return "貝果";
            }
        }

        public dynamic GetCost()
        {
            return (dynamic)30;
        }

        public string GetDescription()
        {
            return this.description;
        }
    }
}
