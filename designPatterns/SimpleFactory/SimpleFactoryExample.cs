using System;

namespace designPatterns.SimpleFactory
{
    /// <summary>
    /// 簡單工廠
    /// 範例參考來源:大話設計模式
    /// </summary>
    public class SimpleFactoryExample : IPatternExample
    {
        public void DoWork()
        {
            var oper = new OperationFactory();
            var newOpernByAdd = oper.CreateOperate(OperationObject.add);
            var newOperByMul = oper.CreateOperate(OperationObject.Mul);
            Console.WriteLine(newOpernByAdd.GetResult((decimal)1.3, (decimal)8.2));
            Console.WriteLine(newOperByMul.GetResult((decimal)2.2, (decimal)1.1));
        }
    }
}
