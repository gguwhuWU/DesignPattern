namespace designPatterns.Bridge
{
    public interface IBrand
    {
        string BrandName { get; }
        string BrandVersion { get; }
        void SwitchPowerSupply();
        void SwitchAirVolume();
        void TurnUpAC();
        void TurnDownAC();
        void ChangeFeatures();
        void ShowMessage();
        void SetRemoteControl(IRemoteControl remoteControl);
    }
}
