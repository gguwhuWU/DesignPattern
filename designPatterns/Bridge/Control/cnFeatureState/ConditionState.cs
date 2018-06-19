using System;

namespace designPatterns.Bridge.Control.cnFeatureState
{
    public class ConditionState : IState
    {
        public void NextState(IRemoteControl control)
        {
            if (control.CurrentFeature == FeatureType.Condition)
            {
                control.CurrentFeature = FeatureType.Fan;
                Console.WriteLine("目前轉成送風模式");
            }
            else
            {
                control.FeatureState = new FanState();
                control.ChangeFeatures();
            }
        }
    }
}
