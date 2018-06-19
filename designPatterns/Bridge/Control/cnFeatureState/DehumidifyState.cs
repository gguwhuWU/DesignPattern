using System;

namespace designPatterns.Bridge.Control.cnFeatureState
{
    public class DehumidifyState : IState
    {
        public void NextState(IRemoteControl control)
        {
            if (control.CurrentFeature == FeatureType.Dehumidify)
            {
                control.CurrentFeature = FeatureType.Sleep;
                Console.WriteLine("目前轉成睡眠模式");
            }
            else
            {
                control.FeatureState = new SleepState();
                control.ChangeFeatures();
            }
        }
    }
}
