using System;

namespace designPatterns.Bridge.Control.cnFeatureState
{
    public class FanState : IState
    {
        public void NextState(IRemoteControl control)
        {
            if (control.CurrentFeature == FeatureType.Fan)
            {
                control.CurrentFeature = FeatureType.Dehumidify;
                Console.WriteLine("目前轉成除濕模式");
            }
            else
            {
                control.FeatureState = new DehumidifyState();
                control.ChangeFeatures();
            }
        }
    }
}
