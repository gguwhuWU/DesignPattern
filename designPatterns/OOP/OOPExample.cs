using designPatterns.OOP.Animals;
using System;
using System.Collections.Generic;

namespace designPatterns.OOP
{
    /// <summary>
    /// 物件導向
    /// 範例來源:
    /// 大話設計模式
    /// 範例參考來源:
    /// https://zh.wikipedia.org/wiki/%E9%9D%A2%E5%90%91%E5%AF%B9%E8%B1%A1%E7%A8%8B%E5%BA%8F%E8%AE%BE%E8%AE%A1
    /// https://www.huanlintalk.com/2009/01/delegate-revisited-csharp-1-to-2-to-3.html
    /// 
    /// 類別(class)是對物件(object)的抽象;'抽象類別(abstract)'是對類別(class)的抽象
    /// </summary>
    public class OOPExample : IPatternExample
    {
        public void DoWork()
        {
            // 將類別實體化
            Cat cat = new Cat("小花");
            cat.Shout(5);
            cat.ShoutNumber = 3;
            cat.AnimalShout();

            Dog dog = new Dog("小白");

            // 泛型(Generic)
            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach(var animal in animals)
            {
                animal.ShowAnimalShout();
            }
            
            List<IChange> animalChanges = new List<IChange>();
            animalChanges.Add(new Doraemon());
            animalChanges.Add(new SunWukong());
            foreach (var animalChange in animalChanges)
            {
                Console.WriteLine(animalChange.ChangeThing("各種東西"));
            }

            Mouse mouse1 = new Mouse("小小");
            Mouse mouse2 = new Mouse("小二");
            Mouse mouse3 = new Mouse("小三");

            // 把 mouse1.Run 這個方法 登記(增加)到 CatShout() 事件當中
            // c# 1.0 寫法
            cat.CatShout += new Cat.CatShoutEventHandler(mouse1.Run);
            cat.CatShout += new Cat.CatShoutEventHandler(mouse2.Run);
            // 這裡移除一個 CatShout()
            cat.CatShout -= new Cat.CatShoutEventHandler(mouse2.Run);

            // c# 2.0 寫法
            Cat.CatShoutEventHandler d2 = mouse3.Run;
            cat.CatShout += d2;
            cat.CatShout += delegate () { Console.WriteLine("2.0"); };
            cat.CatShout2 += mouse3.Run2;
            cat.CatShout3 += mouse3.Run3;
            cat.CatShout3 += delegate (string n) { Console.WriteLine($"{n} - 2.0 - v2"); return false; };

            // c# 3.0 寫法
            Cat.CatShoutEventHandler d3 = () => { Console.WriteLine("3.0"); };
            cat.CatShout += d3;
            cat.CatShout += () => { Console.WriteLine("3.0 - v2"); };
            cat.CatShout3 += n => { Console.WriteLine($"{n} - 3.0 - v2"); return false; };

            cat.Shout();
        }
    }
}
