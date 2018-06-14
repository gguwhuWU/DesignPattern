using System;
using designPatterns.Adapter.Appliance;
using designPatterns.Adapter.Interface;
using External;

namespace designPatterns.Adapter
{
    public class NewSoundAdapterObject : AbstractAppliance, ISound
    {
        private NewSound newSound;
        public NewSoundAdapterObject()
        {
            newSound = new NewSound();
        }

        public void ChangeCDNumber(string CDName)
        {
            Console.WriteLine($"新型不支援此功能!");
        }

        public override void Off()
        {
            if (SwitchButton)
            {
                newSound.Close();
                Switch();
            }
        }

        public override void On()
        {
            if (!SwitchButton)
            {
                newSound.Open();
                Switch();
            }
        }
    }
}
