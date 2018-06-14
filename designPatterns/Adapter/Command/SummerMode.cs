using designPatterns.Adapter.Interface;
using System.Collections.Generic;

namespace designPatterns.Adapter.Command
{
    public class SummerMode : ICommand
    {
        public void DoWork(List<IAppliance> appliances)
        {
            appliances.ForEach(a =>
            {
                if (a.GetType().Name.Equals("AirConditioner"))
                {
                    IAirConditioner aa = (IAirConditioner)a;
                    aa.On();
                    aa.ChangeStrongAirvolume();
                }

                if (a.GetType().Name.Equals("Television") || a.GetType().Name.Equals("Sound"))
                {
                    a.On();
                }
            });
        }
    }
}
