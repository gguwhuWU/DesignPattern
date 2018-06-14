using System;

namespace designPatterns.Prototype
{
    /// <summary>
    /// 原型(複製)
    /// 範例來源:大話設計模式
    /// </summary>
    public class PrototypeExample : IPatternExample
    {
        public void DoWork()
        {
            Resume r1 = new Resume("小吳");
            r1.SetPersonalInfo("m", 25);
            r1.SetWorkExperience(new DateTime(1999, 1, 1), "x公司");

            Resume r2 = (Resume)r1.Clone();
            r2.SetPersonalInfo("f", 20);
            r2.SetWorkExperience(new DateTime(1994, 5, 5), "y公司");

            Resume r3 = (Resume)r1.Clone();
            r3.SetPersonalInfo("f", 22);
            r3.SetWorkExperience(new DateTime(1996, 11, 11), "z公司");

            r1.Display();
            r2.Display();
            r3.Display();
        }
    }
}
