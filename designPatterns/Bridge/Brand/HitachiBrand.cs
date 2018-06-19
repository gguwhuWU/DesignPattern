using System;

namespace designPatterns.Bridge.Brand
{
    public class HitachiBrand : IBrand
    {
        public string BrandName
        {
            get
            {
                return "日立冷氣遙控器";
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

        public void HitachiCustomFeature()
        {
            Console.WriteLine("日立特別功能");
        }

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
            if (remoteControl.CurrentFeature != FeatureType.Condition && remoteControl.CurrentAC <= 22)
            {
                remoteControl.CurrentFeature = FeatureType.Condition;
                Console.WriteLine("低於22度，轉成冷氣模式");
            }
        }

        public void TurnUpAC()
        {
            remoteControl.TurnUpAC();
            if (remoteControl.CurrentFeature != FeatureType.Heat && remoteControl.CurrentAC >= 30)
            {
                remoteControl.CurrentFeature = FeatureType.Heat;
                Console.WriteLine("超過30度，轉成暖氣模式");
            }
        }
    }
}
