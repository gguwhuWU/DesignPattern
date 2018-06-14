using designPatterns.Adapter.Interface;
using System.Collections.Generic;

namespace designPatterns.Adapter.Command
{
    public class AllOn : ICommand
    {
        public void DoWork(List<IAppliance> appliances)
        {
            appliances.ForEach(a =>
            {
                a.On();
            });
        }
    }
}
