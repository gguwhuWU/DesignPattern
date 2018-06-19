using designPatterns.Bridge.Control.cnFeatureState;
using System;

namespace designPatterns.Bridge.Control
{
    public class CNControl : IRemoteControl
    {
        private int currentAC;
        public int CurrentAC
        {
            get
            {
                return currentAC;
            }

            set
            {
                value = currentAC;
            }
        }

        private AirVolumeType currentAirVolume;
        public AirVolumeType CurrentAirVolume
        {
            get
            {
                return currentAirVolume;
            }

            set
            {
                currentAirVolume = value;
            }
        }

        private FeatureType currentFeature;
        public FeatureType CurrentFeature
        {
            get
            {
                return currentFeature;
            }

            set
            {
                currentFeature = value;
            }
        }

        private bool powerSupply;
        public bool PowerSupply
        {
            get
            {
                return powerSupply;
            }

            set
            {
                powerSupply = value;
            }
        }

        private IState featureState;
        public IState FeatureState
        {
            get
            {
                return featureState;
            }

            set
            {
                featureState = value;
            }
        }

        public CNControl()
        {
            // 預設26度
            currentAC = 26;
            featureState = new FanState();
        }

        // 可以改狀態模式
        // 中式沒有暖器模式
        public void ChangeFeatures()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔");
                return;
            }
            
            featureState.NextState(this);
        }

        public void ShowMessage()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔");
                return;
            }

            Console.WriteLine($"{currentAC}度，風量:{currentAirVolume.ToString()},模式:{currentFeature.ToString()}");
        }

        // 可以改狀態模式
        public void SwitchAirVolume()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔");
                return;
            }

            switch (currentAirVolume)
            {
                case AirVolumeType.High:
                    {
                        currentAirVolume = AirVolumeType.Middle;
                        Console.WriteLine("目前轉成中風");
                        break;
                    }
                case AirVolumeType.Middle:
                    {
                        currentAirVolume = AirVolumeType.Low;
                        Console.WriteLine("目前轉成弱風");
                        break;
                    }
                case AirVolumeType.Low:
                    {
                        currentAirVolume = AirVolumeType.Auto;
                        Console.WriteLine("目前轉成風量自動");
                        break;
                    }
                case AirVolumeType.Auto:
                    {
                        currentAirVolume = AirVolumeType.High;
                        Console.WriteLine("目前轉成風量強風");
                        break;
                    }
            }
        }

        public void SwitchPowerSupply()
        {
            if (powerSupply)
            {
                powerSupply = false;
                Console.WriteLine("關機");
            }
            else
            {
                powerSupply = true;
                Console.WriteLine("開機");
            }
        }

        public void TurnDownAC()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔");
                return;
            }

            currentAC--;
            Console.WriteLine($"目前{currentAC}度");
        }

        public void TurnUpAC()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔");
                return;
            }

            currentAC++;
            Console.WriteLine($"目前{currentAC}度");
        }
    }
}
