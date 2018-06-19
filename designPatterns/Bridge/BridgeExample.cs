using designPatterns.Bridge.Brand;
using designPatterns.Bridge.Control;

namespace designPatterns.Bridge
{
    /// <summary>
    /// 橋接
    /// 範例參考來源:
    /// 大話設計模式
    /// https://ithelp.ithome.com.tw/articles/10193914
    /// http://corrupt003-design-pattern.blogspot.com/2017/01/bridge-pattern.html
    /// https://rongli.gitbooks.io/design-pattern/content/chapter7.html
    /// </summary>
    public class BridgeExample : IPatternExample
    {
        public void DoWork()
        {
            var b1 = new DaikinBrand();
            b1.SetRemoteControl(new JPControl());
            b1.ShowMessage();
            b1.SwitchPowerSupply();
            b1.TurnDownAC();
            b1.TurnDownAC();
            b1.ChangeFeatures();
            b1.ChangeFeatures();
            b1.ChangeFeatures();
            b1.ChangeFeatures();
            b1.SwitchAirVolume();
            b1.SwitchAirVolume();
            b1.SwitchAirVolume();
            b1.ShowMessage();
            b1.DaikinCustomFeature();

            var b2 = new PanasonicBrand();
            b2.SetRemoteControl(new CNControl());
            b2.ShowMessage();
            b2.SwitchPowerSupply();
            b2.TurnDownAC();
            b2.TurnDownAC();
            b2.ChangeFeatures();
            b2.ChangeFeatures();
            b2.ChangeFeatures();
            b2.ChangeFeatures();
            b2.SwitchAirVolume();
            b2.SwitchAirVolume();
            b2.SwitchAirVolume();
            b2.ShowMessage();

            var b3 = new HitachiBrand();
            b3.SetRemoteControl(new JPControl());
            b3.HitachiCustomFeature();

            var b4 = new TECOBrand();
            b4.SetRemoteControl(new JPControl());
            b4.SwitchPowerSupply();
            b4.TECOCustomFeature();
            b4.ShowMessage();

            b4.SetRemoteControl(new CNControl());
            b4.SwitchPowerSupply();
            b4.TECOCustomFeature();
            b4.ShowMessage();
        }
    }
}
