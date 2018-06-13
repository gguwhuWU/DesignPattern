namespace designPatterns.AbstractFactory
{
    public interface ISeafoodPizza
    {
        void CreateSeafoodPizza(int seasoningNumber, int concentrationNumber);

        void CreateSpecialSeafoodPizza(int seasoningNumber, int concentrationNumber);
    }
}
