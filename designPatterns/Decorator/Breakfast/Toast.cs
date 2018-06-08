namespace designPatterns.Decorator.Breakfast
{
    public class Toast : IBreakfast
    {
        public string description
        {
            get
            {
                return "吐司";
            }
        }

        public dynamic GetCost()
        {
            return (dynamic)15;
        }

        public string GetDescription()
        {
            return this.description;
        }
    }
}
