using System;

namespace designPatterns.Bridge.Control.cnFeatureState
{
    public class SleepState : IState
    {
        public void NextState(IRemoteControl control)
        {
            if (control.CurrentFeature == FeatureType.Sleep)
            {
                control.CurrentFeature = FeatureType.Condition;
                Console.WriteLine("目前轉成冷氣模式");
            }
            else
            {
                control.FeatureState = new ConditionState();
                control.ChangeFeatures();
            }
        }
    }
}
