using System;

namespace designPatterns.OOP.Animals
{
    public class Mouse : Animal
    {
        // 方法重載
        public Mouse(string name) : base(name)
        {
        }

        // 建構式
        public Mouse() : base()
        {
            name = "無名";
        }

        protected override string ShoutSound
        {
            get
            {
                return "吱吱";
            }
        }

        public void Run()
        {
            Console.WriteLine($"小小貓咪 來了! {name} 快跑");
        }

        // 接收傳遞者的資料
        public void Run2(object sender, CatShoutEventArgs2 args)
        {
            Console.WriteLine($"小貓咪 {args.Name} 來了! {name} 快跑");
        }

        public bool Run3(string catName)
        {
            if (catName == "小花")
            {
                Console.WriteLine($"貓咪霸主 {catName} 來了! {name} 快跑!");
                return true;
            }

            Console.WriteLine($"貓咪 {catName} 來了! {name} 快跑!");
            return false;
        }
    }
}
