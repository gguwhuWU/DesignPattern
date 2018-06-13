using System.Reflection;
using System.Configuration;

namespace designPatterns.AbstractFactory
{
    /// <summary>
    /// 正確反射時 Method不應該有根據不同工廠帶入不同值情況(int seasoningNumber, int concentrationNumbe) 這兩個放下給各自class去實作，不一樣的只限產生的Class就夠了 (這個class又根據反射決定)
    /// </summary>
    public class ReflectionPizzaFactory : IPizzaFactory
    {
        private IBeefPizza beefPizze;
        private IHawaiiPizza hawaiiPizza;
        private ISeafoodPizza seafoodPizza;
        private ITakoyakiPizza takoyakiPizza;

        public ReflectionPizzaFactory()
        {
            //string storeName = "PizzaHutPizza";
            //string beefPizzeName = "PH_BeefPizza";
            //string hawaiiPizzaName = "PH_HawaiiPizza";
            //string seafoodPizzaName = "PH_SeafoodPizza";
            //string takoyakiPizzaName = "PH_TakoyakiPizza";
            string storeName = ConfigurationManager.AppSettings["storeName"];
            string beefPizzeName = ConfigurationManager.AppSettings["beefPizzeName"];
            string hawaiiPizzaName = ConfigurationManager.AppSettings["hawaiiPizzaName"];
            string seafoodPizzaName = ConfigurationManager.AppSettings["seafoodPizzaName"];
            string takoyakiPizzaName = ConfigurationManager.AppSettings["takoyakiPizzaName"];

            ///使用反射 產生相對應的物件
            beefPizze = (IBeefPizza)Assembly.Load("designPatterns").CreateInstance($"designPatterns.AbstractFactory.{storeName}.{beefPizzeName}");
            hawaiiPizza = (IHawaiiPizza)Assembly.Load("designPatterns").CreateInstance($"designPatterns.AbstractFactory.{storeName}.{hawaiiPizzaName}");
            seafoodPizza = (ISeafoodPizza)Assembly.Load("designPatterns").CreateInstance($"designPatterns.AbstractFactory.{storeName}.{seafoodPizzaName}");
            takoyakiPizza = (ITakoyakiPizza)Assembly.Load("designPatterns").CreateInstance($"designPatterns.AbstractFactory.{storeName}.{takoyakiPizzaName}");
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
