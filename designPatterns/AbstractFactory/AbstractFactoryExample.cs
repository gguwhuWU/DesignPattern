namespace designPatterns.AbstractFactory
{
    /// <summary>
    /// 抽象工廠
    /// 範例參考來源:
    /// 大話設計模式
    /// https://blog.techbridge.cc/2017/05/22/factory-method-and-abstract-factory/
    /// https://skyyen999.gitbooks.io/-study-design-pattern-in-java/content/abstractFactory1.html
    /// </summary>
    public class AbstractFactoryExample : IPatternExample
    {
        public void DoWork()
        {
            IPizzaFactory pizzaFactory = new PizzaHutPizzaFactory();
            //IPizzaFactory pizzaFactory = new DominosPizzaFactory();

            pizzaFactory.CreateHawaiiPizza();
            pizzaFactory.CreateSpecialTakoyakiPizza();

            // 使用 基本反射
            pizzaFactory.CreateBeefPizza();

            // 使用 反射的工廠
            IPizzaFactory pizzaFactoryOfReflection = new ReflectionPizzaFactory();
            pizzaFactoryOfReflection.CreateSpecialBeefPizza();
        }
    }
}
