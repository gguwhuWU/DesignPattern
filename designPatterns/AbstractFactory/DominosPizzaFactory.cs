using designPatterns.AbstractFactory.DominosPizza;

namespace designPatterns.AbstractFactory
{
    public class DominosPizzaFactory : IPizzaFactory
    {
        private D_BeefPizza beefPizze;
        private D_HawaiiPizza hawaiiPizza;
        private D_SeafoodPizza seafoodPizza;
        private D_TakoyakiPizza takoyakiPizza;

        public DominosPizzaFactory()
        {
            beefPizze = new D_BeefPizza();
            hawaiiPizza = new D_HawaiiPizza();
            seafoodPizza = new D_SeafoodPizza();
            takoyakiPizza = new D_TakoyakiPizza();
        }

        public void CreateBeefPizza()
        {
            beefPizze.CreateBeefPizza(10, 5);
        }

        public void CreateHawaiiPizza()
        {
            hawaiiPizza.CreateHawaiiPizza(11, 3);
        }

        public void CreateSeafoodPizza()
        {
            seafoodPizza.CreateSeafoodPizza(13, 5);
        }

        public void CreateSpecialBeefPizza()
        {
            beefPizze.CreateSpecialBeefPizza(8, 5);
        }

        public void CreateSpecialHawaiiPizza()
        {
            hawaiiPizza.CreateSpecialHawaiiPizza(9, 8);
        }

        public void CreateSpecialSeafoodPizza()
        {
            seafoodPizza.CreateSpecialSeafoodPizza(5, 7);
        }

        public void CreateSpecialTakoyakiPizza()
        {
            takoyakiPizza.CreateSpecialTakoyakiPizza(3, 1);
        }

        public void CreateTakoyakiPizza()
        {
            takoyakiPizza.CreateTakoyakiPizza(2, 4);
        }
    }
}
