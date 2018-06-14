using designPatterns.Adapter.Interface;
using System;

namespace designPatterns.Adapter.Appliance
{
    public class Dehumidifier : AbstractAppliance, IDehumidifier
    {
        public void ChangeNormalDehumidifier()
        {
            Console.WriteLine("中等除濕");
        }

        public void ChangeStrongDehumidifier()
        {
            Console.WriteLine("強力除濕");
        }

        public void ChangeWeakDehumidifier()
        {
            Console.WriteLine("微弱除濕");
        }

        public override void Off()
        {
            if (SwitchButton)
            {
                Switch();
                Console.WriteLine("關閉除濕機");
            }
        }

        public override void On()
        {
            if (!SwitchButton)
            {
                Switch();
                Console.WriteLine("啟動除濕機");
            }
        }
    }
}
