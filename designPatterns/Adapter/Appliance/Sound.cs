using designPatterns.Adapter.Interface;
using System;

namespace designPatterns.Adapter.Appliance
{
    public class Sound : AbstractAppliance, ISound
    {
        public void ChangeCDNumber(string CDName)
        {
            Console.WriteLine($"播放{CDName}");
        }

        public override void Off()
        {
            if (SwitchButton)
            {
                Switch();
                Console.WriteLine("關閉音響");
            }
        }

        public override void On()
        {
            if (!SwitchButton)
            {
                Switch();
                Console.WriteLine("啟動音響");
            }
        }
    }
}
