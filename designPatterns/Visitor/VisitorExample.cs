using designPatterns.Visitor.Persons;
using designPatterns.Visitor.Actions;
using System;

namespace designPatterns.Visitor
{
    /// <summary>
    /// 訪問者
    /// 範例來源:
    /// 大話設計模式
    /// 範例參考來源:
    /// https://xyz.cinc.biz/2013/08/visitor-pattern.html
    /// </summary>
    public class VisitorExample : IPatternExample
    {
        public void DoWork()
        {
            // 物件結構
            ObjectStructure o = new ObjectStructure();
            // 男人元素物件
            Man man = new Man();
            // 女人元素物件
            Woman woman = new Woman();

            // 將元素物件放進物件結構
            o.Attach(man);
            o.Attach(woman);
            
            // 訪問者1
            Success success = new Success();
            Console.WriteLine("[事件1]");
            o.Display(success); // 輸出結果

            // 訪問者2
            Fail fail = new Fail();
            Console.WriteLine("[事件2]");
            o.Display(fail); // 輸出結果
        }
    }
}
