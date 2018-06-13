namespace designPatterns.AbstractFactory
{
    public interface IBeefPizza
    {
        void CreateBeefPizza(int seasoningNumber, int concentrationNumber);

        void CreateSpecialBeefPizza(int seasoningNumber, int concentrationNumber);
    }
}
