using designPatterns.Adapter.Interface;
using System;

namespace designPatterns.Adapter.Appliance
{
    public class AirPurifier : AbstractAppliance, IAirPurifier
    {
        public void ChangeNormalPurifier()
        {
            Console.WriteLine("中等清淨");
        }

        public void ChangeStrongPurifier()
        {
            Console.WriteLine("強力清淨");
        }

        public void ChangeWeakPurifier()
        {
            Console.WriteLine("微弱清淨");
        }

        public override void Off()
        {
            if (SwitchButton)
            {
                Switch();
                Console.WriteLine("關閉空氣清淨機");
            }
        }

        public override void On()
        {
            if (!SwitchButton)
            {
                Switch();
                Console.WriteLine("啟動空氣清淨機");
            }
        }
    }
}
