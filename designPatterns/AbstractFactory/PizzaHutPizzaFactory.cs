using designPatterns.AbstractFactory.PizzaHutPizza;
using System.Reflection;

namespace designPatterns.AbstractFactory
{
    public class PizzaHutPizzaFactory : IPizzaFactory
    {
        private IBeefPizza beefPizze;
        private PH_HawaiiPizza hawaiiPizza;
        private PH_SeafoodPizza seafoodPizza;
        private PH_TakoyakiPizza takoyakiPizza;

        public PizzaHutPizzaFactory()
        {
            ///使用反射 產生相對應的物件
            beefPizze = (IBeefPizza)Assembly.Load("designPatterns").CreateInstance("designPatterns.AbstractFactory.PizzaHutPizza.PH_BeefPizza");
            hawaiiPizza = new PH_HawaiiPizza();
            seafoodPizza = new PH_SeafoodPizza();
            takoyakiPizza = new PH_TakoyakiPizza();
        }

        public void CreateBeefPizza()
        {
            beefPizze.CreateBeefPizza(1, 5);
        }

        public void CreateHawaiiPizza()
        {
            hawaiiPizza.CreateHawaiiPizza(1, 2);
        }

        public void CreateSeafoodPizza()
        {
            seafoodPizza.CreateSeafoodPizza(10, 4);
        }

        public void CreateSpecialBeefPizza()
        {
            beefPizze.CreateSpecialBeefPizza(2, 15);
        }

        public void CreateSpecialHawaiiPizza()
        {
            hawaiiPizza.CreateSpecialHawaiiPizza(19, 6);
        }

        public void CreateSpecialSeafoodPizza()
        {
            seafoodPizza.CreateSpecialSeafoodPizza(1, 5);
        }

        public void CreateSpecialTakoyakiPizza()
        {
            takoyakiPizza.CreateSpecialTakoyakiPizza(7, 12);
        }

        public void CreateTakoyakiPizza()
        {
            takoyakiPizza.CreateTakoyakiPizza(1, 14);
        }
    }
}
