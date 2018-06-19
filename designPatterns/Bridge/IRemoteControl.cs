using designPatterns.Bridge.Control;
using System;

namespace designPatterns.Bridge
{
    public interface IRemoteControl
    {
        IState FeatureState { get; set; }
        bool PowerSupply { get; set; }
        AirVolumeType CurrentAirVolume { get; set; }
        int CurrentAC { get; set; }
        FeatureType CurrentFeature { get; set; }
        void SwitchPowerSupply();
        void SwitchAirVolume();
        void TurnUpAC();
        void TurnDownAC();
        void ChangeFeatures();
        void ShowMessage();
    }
}
