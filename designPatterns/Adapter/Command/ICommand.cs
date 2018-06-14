using designPatterns.Adapter.Interface;
using System.Collections.Generic;

namespace designPatterns.Adapter.Command
{
    public interface ICommand
    {
        void DoWork(List<IAppliance> appliances);
    }
}
