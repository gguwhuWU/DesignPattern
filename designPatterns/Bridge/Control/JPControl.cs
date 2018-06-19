using System;

namespace designPatterns.Bridge.Control
{
    public class JPControl : IRemoteControl
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

        // 因為 cn 有實作狀態模式，這裡就不再寫一遍
        public IState FeatureState
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public JPControl()
        {
            // 預設25度
            currentAC = 25;
        }

        // 可以改狀態模式
        public void ChangeFeatures()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔(日文)");
                return;
            }

            switch (currentFeature)
            {
                case FeatureType.Fan:
                    {
                        currentFeature = FeatureType.Dehumidify;
                        Console.WriteLine("目前轉成除濕模式(日文)");
                        break;
                    }
                case FeatureType.Dehumidify:
                    {
                        currentFeature = FeatureType.Sleep;
                        Console.WriteLine("目前轉成睡眠模式(日文)");
                        break;
                    }
                case FeatureType.Sleep:
                    {
                        currentFeature = FeatureType.Condition;
                        Console.WriteLine("目前轉成冷氣模式(日文)");
                        break;
                    }
                case FeatureType.Condition:
                    {
                        currentFeature = FeatureType.Heat;
                        Console.WriteLine("目前轉成暖氣模式(日文)");
                        break;
                    }
                case FeatureType.Heat:
                    {
                        currentFeature = FeatureType.Fan;
                        Console.WriteLine("目前轉成送風模式(日文)");
                        break;
                    }
            }
        }

        public void ShowMessage()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔(日文)");
                return;
            }

            Console.WriteLine($"{currentAC}度，風量:{currentAirVolume.ToString()},模式:{currentFeature.ToString()}(日文)");
        }

        // 可以改狀態模式
        // 沒有自動風量
        public void SwitchAirVolume()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔(日文)");
                return;
            }

            switch (currentAirVolume)
            {
                case AirVolumeType.High:
                    {
                        currentAirVolume = AirVolumeType.Middle;
                        Console.WriteLine("目前轉成中風(日文)");
                        break;
                    }
                case AirVolumeType.Middle:
                    {
                        currentAirVolume = AirVolumeType.Low;
                        Console.WriteLine("目前轉成弱風(日文)");
                        break;
                    }
                case AirVolumeType.Low:
                    {
                        currentAirVolume = AirVolumeType.High;
                        Console.WriteLine("目前轉成風量強風(日文)");
                        break;
                    }
            }
        }

        public void SwitchPowerSupply()
        {
            if (powerSupply)
            {
                powerSupply = false;
                Console.WriteLine("關機(日文)");
            }
            else
            {
                powerSupply = true;
                Console.WriteLine("開機(日文)");
            }
        }
        
        public void TurnDownAC()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔(日文)");
                return;
            }

            currentAC--;
            Console.WriteLine($"目前{currentAC}度(日文)");
        }

        public void TurnUpAC()
        {
            if (!powerSupply)
            {
                Console.WriteLine("沒開機喔(日文)");
                return;
            }

            currentAC++;
            Console.WriteLine($"目前{currentAC}度(日文)");
        }
    }
}
