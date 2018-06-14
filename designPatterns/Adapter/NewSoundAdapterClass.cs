using System;
using designPatterns.Adapter.Interface;
using External;

namespace designPatterns.Adapter
{
    public class NewSoundAdapterClass : NewSound, ISound
    {
        private bool switchButton;
        public bool SwitchButton
        {
            get
            {
                return switchButton;
            }

            set
            {
                switchButton = value;
            }
        }

        public void ChangeCDNumber(string CDName)
        {
            Console.WriteLine($"新型不支援此功能!");
        }

        public void Off()
        {
            if (SwitchButton)
            {
                Close();
                switchButton = false;
            }
        }

        public void On()
        {
            if (!SwitchButton)
            {
                Open();
                switchButton = true;
            }
        }
    }
}
