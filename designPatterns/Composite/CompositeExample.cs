using designPatterns.Composite.Company;
using System;

namespace designPatterns.Composite
{
    /// <summary>
    /// 組合
    /// 範例參考來源:
    /// 大話設計模式
    /// https://xyz.cinc.biz/2013/07/composite-pattern.html
    /// https://dotblogs.com.tw/ricochen/2012/08/08/73906
    /// </summary>
    public class CompositeExample : IPatternExample
    {
        public void DoWork()
        {
            ConcreteCompany root = new ConcreteCompany("總公司");
            root.Add(new HRDepartment("總公司人資部"));
            root.Add(new FinanceDepartment("總公司財務部"));
            root.Add(new ITDepartment("總公司資訊服務部"));

            ConcreteCompany tw = new ConcreteCompany("台灣總部");
            tw.Add(new HRDepartment("台灣總部人資部"));
            tw.Add(new FinanceDepartment("台灣總部財務部"));
            tw.Add(new ITDepartment("台灣總部資訊服務部"));
            root.Add(tw);

            ConcreteCompany twc = new ConcreteCompany("台灣中部分部");
            twc.Add(new HRDepartment("台灣中部分人資部"));
            twc.Add(new FinanceDepartment("台灣中部分部財務部"));
            twc.Add(new ITDepartment("台灣中部分部資訊服務部"));
            tw.Add(twc);

            ConcreteCompany twc2 = new ConcreteCompany("台灣中部台中分部");
            twc2.Add(new HRDepartment("台灣中部台中分部人資部"));
            twc2.Add(new FinanceDepartment("台灣中部台中分部財務部"));
            twc2.Add(new ITDepartment("台灣中部台中分部資訊服務部"));
            twc.Add(twc2);

            ConcreteCompany jp = new ConcreteCompany("日本總部");
            jp.Add(new HRDepartment("日本總部人資部"));
            jp.Add(new FinanceDepartment("日本總部財務部"));
            jp.Add(new ITDepartment("日本總部資訊服務部"));
            root.Add(jp);

            ConcreteCompany jp2 = new ConcreteCompany("日本大阪分部");
            jp2.Add(new HRDepartment("日本大阪分部人資部"));
            jp2.Add(new FinanceDepartment("日本大阪分部財務部"));
            jp2.Add(new ITDepartment("日本大阪分部資訊服務部"));
            jp.Add(jp2);

            Console.WriteLine("\n結構圖:");
            root.Display(1);
            Console.WriteLine("\n工作:");
            root.DoWork();
        }
    }
}
