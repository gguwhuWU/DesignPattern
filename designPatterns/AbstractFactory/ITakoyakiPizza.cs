namespace designPatterns.AbstractFactory
{
    public interface ITakoyakiPizza
    {
        void CreateTakoyakiPizza(int seasoningNumber, int concentrationNumber);

        void CreateSpecialTakoyakiPizza(int seasoningNumber, int concentrationNumber);
    }
}
