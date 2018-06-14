using designPatterns.Adapter.Interface;

namespace designPatterns.Adapter.Appliance
{
    public abstract class AbstractAppliance : IAppliance
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

        public void Switch()
        {
            if (SwitchButton)
            {
                SwitchButton = false;
            }
            else
            {
                SwitchButton = true;
            }
        }

        public abstract void Off();

        public abstract void On();
    }
}
