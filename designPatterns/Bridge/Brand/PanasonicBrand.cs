using System;

namespace designPatterns.Bridge.Brand
{
    public class PanasonicBrand : IBrand
    {
        public string BrandName
        {
            get
            {
                return "國際冷氣遙控器";
            }
        }

        public string BrandVersion
        {
            get
            {
                return "1.0.0";
            }
        }

        private IRemoteControl remoteControl;
        
        public void ChangeFeatures()
        {
            remoteControl.ChangeFeatures();
        }

        public void SetRemoteControl(IRemoteControl remoteControl)
        {
            this.remoteControl = remoteControl;
        }

        public void ShowMessage()
        {
            remoteControl.ShowMessage();
        }

        public void SwitchAirVolume()
        {
            remoteControl.SwitchAirVolume();
        }

        public void SwitchPowerSupply()
        {
            remoteControl.SwitchPowerSupply();
        }
        
        public void TurnDownAC()
        {
            remoteControl.TurnDownAC();
            if (remoteControl.CurrentFeature != FeatureType.Condition && remoteControl.CurrentAC <= 20)
            {
                remoteControl.CurrentFeature = FeatureType.Condition;
                Console.WriteLine("低於20度，轉成冷氣模式");
            }
        }

        public void TurnUpAC()
        {
            remoteControl.TurnUpAC();
            if (remoteControl.CurrentFeature != FeatureType.Heat && remoteControl.CurrentAC >= 28)
            {
                remoteControl.CurrentFeature = FeatureType.Heat;
                Console.WriteLine("超過28度，轉成暖氣模式");
            }
        }
    }
}
