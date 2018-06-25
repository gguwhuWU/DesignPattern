using System;

namespace designPatterns.OOP.Animals
{
    /// <summary>
    /// class = 類別關鍵字
    /// Cat 類別名稱
    /// 1.封裝 (Encapsulation)
    ///   隱藏了某一方法的具體執行步驟，取而代之的是通過訊息傳遞機制傳送訊息給它。
    /// abstract 目前是 抽像類別
    /// </summary>
    public abstract class Animal
    {
        protected string name;
        // 抽像屬性
        protected abstract string ShoutSound { get; }

        // 屬性與修飾子
        private int shoutNumber = 2;
        public int ShoutNumber
        {
            get
            {
                return shoutNumber;
            }
            set
            {
                if (value <= 5)
                {
                    shoutNumber = value;
                }
                else
                {
                    shoutNumber = 5;
                }
            }
        }

        // 方法重載
        public Animal(string name)
        {
            this.name = name;
        }

        // 建構式
        public Animal()
        {
            name = "無名";
        }

        public virtual string AnimalShout()
        {
            return "";
        }

        public void ShowAnimalShout()
        {
            string s = "";
            for (int i = 0; i < ShoutNumber; i++)
            {
                s = s + ShoutSound;
            }

            Console.WriteLine($"{name}:{s}");
        }
    }
}
