using designPatterns.Adapter.Command;
using designPatterns.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace designPatterns.Adapter
{
    public class ControlCenter
    {
        private List<IAppliance> appliances;

        public ControlCenter(List<IAppliance> appliances)
        {
            this.appliances = appliances;
        }

        public void Start()
        {
            Console.WriteLine("啟動 家電控制系統");
        }

        public void DoWork(string command)
        {
            Console.WriteLine("-----------------");

            try
            {
                var realCommand = (ICommand)Assembly.Load("designPatterns").CreateInstance($"designPatterns.Adapter.Command.{command}");
                realCommand.DoWork(appliances);
            }
            catch(NullReferenceException nrex)
            {
                Console.WriteLine("錯誤指令!");
                Console.WriteLine(nrex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
    }
}
