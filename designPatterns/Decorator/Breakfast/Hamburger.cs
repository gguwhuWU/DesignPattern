namespace designPatterns.Decorator.Breakfast
{
    public class Hamburger : IBreakfast
    {
        public string description
        {
            get
            {
                return "漢堡";
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
