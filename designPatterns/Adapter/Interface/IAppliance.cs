namespace designPatterns.Adapter.Interface
{
    public interface IAppliance
    {
        bool SwitchButton { get; set; }

        void On();

        void Off();
    }
}
