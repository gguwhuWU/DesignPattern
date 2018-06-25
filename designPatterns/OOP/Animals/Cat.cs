using System;

namespace designPatterns.OOP.Animals
{
    /// <summary>
    /// class = 類別關鍵字
    /// Cat 類別名稱
    /// 1.封裝 (Encapsulation)
    ///   隱藏了某一方法的具體執行步驟，取而代之的是通過訊息傳遞機制傳送訊息給它。
    /// </summary>
    public class Cat : Animal
    {
        // 方法重載
        public Cat(string name) : base(name)
        {
        }

        // 建構式
        public Cat() : base()
        {
            name = "無名";
        }

        protected override string ShoutSound
        {
            get
            {
                return "喵";
            }
        }

        // 宣告委託
        public delegate void CatShoutEventHandler();
        // 多傳遞資料
        public delegate void CatShoutEventHandler2(object sender, CatShoutEventArgs2 args);
        public delegate bool CatShoutEventHandler3(string name);

        //宣告委託事件
        public event CatShoutEventHandler CatShout;
        public event CatShoutEventHandler2 CatShout2;
        public event CatShoutEventHandler3 CatShout3;
        /// <summary>
        /// 類別方法
        /// </summary>
        public void Shout()
        {
            Console.WriteLine($"{name}:喵");

            //if (CatShout != null)
            //{
            //    CatShout();
            //}

            // 執行 CatShout() 等同上面
            CatShout?.Invoke();
            if (CatShout2 != null)
            {
                CatShoutEventArgs2 e = new CatShoutEventArgs2();
                e.Name = name;
                CatShout2(this, e);
            }

            CatShout3?.Invoke(name);
        }

        /// <summary>
        /// 類別方法 / 方法重載
        /// </summary>
        public void Shout(int number)
        {
            string s = "";
            while (number > 0)
            {
                s = s + "喵";
                number--;
            }

            Console.WriteLine($"{name}:{s}");
        }

        public override string AnimalShout()
        {
            string s = "";
            for (int i = 0; i < ShoutNumber; i++)
            {
                s = s + "喵";
            }

            return ($"{name}:{s}");
        }
    }
}
