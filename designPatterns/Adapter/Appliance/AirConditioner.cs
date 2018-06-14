using designPatterns.Adapter.Interface;
using System;

namespace designPatterns.Adapter.Appliance
{
    public class AirConditioner : AbstractAppliance, IAirConditioner
    {
        public void ChangeNormalAirvolume()
        {
            Console.WriteLine("吹出中度風量");
        }

        public void ChangeStrongAirvolume()
        {
            Console.WriteLine("吹出強度風量");
        }

        public void ChangeWeakAirvolume()
        {
            Console.WriteLine("吹出弱度風量");
        }

        public override void Off()
        {
            if (SwitchButton)
            {
                Switch();
                Console.WriteLine("關閉冷氣");
            }
        }

        public override void On()
        {
            if (!SwitchButton)
            {
                Switch();
                Console.WriteLine("啟動冷氣");
            }
        }
    }
}
