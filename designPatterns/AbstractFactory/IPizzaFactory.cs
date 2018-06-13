namespace designPatterns.AbstractFactory
{
    public interface IPizzaFactory
    {
        /// <summary>
        /// 產生海鮮披薩
        /// </summary>
        void CreateSeafoodPizza();

        /// <summary>
        /// 產生牛肉披薩
        /// </summary>
        void CreateBeefPizza();

        /// <summary>
        /// 產生夏威夷披薩
        /// </summary>
        void CreateHawaiiPizza();

        /// <summary>
        /// 章魚燒披薩
        /// </summary>
        void CreateTakoyakiPizza();

        /// <summary>
        /// 產生特製海鮮披薩
        /// </summary>
        void CreateSpecialSeafoodPizza();

        /// <summary>
        /// 產生特製牛肉披薩
        /// </summary>
        void CreateSpecialBeefPizza();

        /// <summary>
        /// 產生特製夏威夷披薩
        /// </summary>
        void CreateSpecialHawaiiPizza();

        /// <summary>
        /// 產生特製章魚燒披薩
        /// </summary>
        void CreateSpecialTakoyakiPizza();
    }
}
