using designPatterns.Facade.SubSystem;
using System;

namespace designPatterns.Facade
{
    public class FacadeSystem
    {
        SubSystem1 sub1;
        SubSystem2 sub2;
        SubSystem3 sub3;
        SubSystem4 sub4;

        public FacadeSystem()
        {
            sub1 = new SubSystem1();
            sub2 = new SubSystem2();
            sub3 = new SubSystem3();
            sub4 = new SubSystem4();
        }

        public void MethodA()
        {
            Console.WriteLine("組合A");
            sub1.Method();
            sub3.Method();
        }

        public void MethodB()
        {
            Console.WriteLine("組合B");
            sub2.Method();
            sub4.Method();
        }
    }
}
