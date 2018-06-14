using designPatterns.Adapter.Appliance;
using designPatterns.Adapter.Interface;
using System.Collections.Generic;

namespace designPatterns.Adapter
{
    /// <summary>
    /// 轉接器
    /// 範例參考來源:
    /// 大話設計模式
    /// https://dotblogs.com.tw/pin0513/2010/05/30/15497
    /// </summary>
    public class AdapterExample : IPatternExample
    {
        public void DoWork()
        {
            List<IAppliance> appliances = new List<IAppliance>();
            appliances.Add(new AirConditioner());
            appliances.Add(new AirPurifier());
            appliances.Add(new Dehumidifier());
            appliances.Add(new Sound());
            appliances.Add(new NewSoundAdapterObject());
            //appliances.Add(new NewSoundAdapterClass());
            appliances.Add(new Television());

            ControlCenter controlCenter = new ControlCenter(appliances);

            controlCenter.Start();

            /// 給使用者按下按鈕(command)
            //while (true)
            //{
            //    controlCenter.DoWork(Console.ReadLine());
            //}

            controlCenter.DoWork("AllOn");
            controlCenter.DoWork("AllOff");
            controlCenter.DoWork("errorCommand");
            controlCenter.DoWork("SummerMode");
            controlCenter.DoWork("AllOff");
            controlCenter.DoWork("CustomMode1");
        }
    }
}
