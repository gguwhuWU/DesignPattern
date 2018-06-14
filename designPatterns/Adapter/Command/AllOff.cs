using designPatterns.Adapter.Interface;
using System.Collections.Generic;

namespace designPatterns.Adapter.Command
{
    public class AllOff : ICommand
    {
        public void DoWork(List<IAppliance> appliances)
        {
            appliances.ForEach(a =>
            {
                a.Off();
            });
        }
    }
}
