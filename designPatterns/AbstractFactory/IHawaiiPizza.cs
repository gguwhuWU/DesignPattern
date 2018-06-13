namespace designPatterns.AbstractFactory
{
    public interface IHawaiiPizza
    {
        void CreateHawaiiPizza(int seasoningNumber, int concentrationNumber);

        void CreateSpecialHawaiiPizza(int seasoningNumber, int concentrationNumber);
    }
}
