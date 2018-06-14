using designPatterns.Adapter.Interface;
using System;

namespace designPatterns.Adapter.Appliance
{
    public class Television : AbstractAppliance, ITelevision
    {
        public void ChangeTVNumber(int number)
        {
            Console.WriteLine($"轉到{number}台");
        }

        public override void Off()
        {
            if (SwitchButton)
            {
                SwitchButton = false;
                Console.WriteLine("關閉電視");
            }
        }

        public override void On()
        {
            if (!SwitchButton)
            {
                SwitchButton = true;
                Console.WriteLine("啟動電視");
            }
        }
    }
}
