namespace designPatterns.OOP.Animals
{
    /// <summary>
    /// 2.繼承(Inheritance)
    ///   一個類別會有「子類別」。子類別比原本的類別（稱為父類別）要更加具體化。
    /// </summary>
    public class Dog : Animal
    {
        // 方法重載
        public Dog(string name) : base(name)
        {
        }

        // 建構式
        public Dog() : base()
        {
            name = "無名";
        }

        protected override string ShoutSound
        {
            get
            {
                return "汪";
            } 
        }

        /// <summary>
        /// 覆寫方法
        /// 3.多型（Polymorphism）
        ///   指由繼承而產生的相關的不同的類別，其物件對同一訊息會做出不同的回應 
        /// </summary>
        public override string AnimalShout()
        {
            string s = "";
            for (int i = 0; i < ShoutNumber; i++)
            {
                s = s + "汪";
            }

            return ($"{name}:{s}");
        }
    }
}
