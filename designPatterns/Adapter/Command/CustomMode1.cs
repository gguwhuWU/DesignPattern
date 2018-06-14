using designPatterns.Adapter.Interface;
using System.Collections.Generic;

namespace designPatterns.Adapter.Command
{
    /// <summary>
    /// 參數應該要從 資料庫 或 設定檔讀取
    /// </summary>
    public class CustomMode1 : ICommand
    {
        public void DoWork(List<IAppliance> appliances)
        {
            appliances.ForEach(a =>
            {
                if (a.GetType().Name.Equals("AirConditioner"))
                {
                    IAirConditioner aac = (IAirConditioner)a;
                    aac.On();
                    aac.ChangeWeakAirvolume();
                }

                if (a.GetType().Name.Equals("AirPurifier"))
                {
                    IAirPurifier aap = (IAirPurifier)a;
                    aap.On();
                    aap.ChangeWeakPurifier();
                }

                if (a.GetType().Name.Equals("Dehumidifier"))
                {
                    IDehumidifier ad = (IDehumidifier)a;
                    ad.On();
                    ad.ChangeWeakDehumidifier();
                }

                if (a.GetType().Name.Equals("Sound"))
                {
                    ISound @as = (ISound)a;
                    @as.On();
                    @as.ChangeCDNumber("jojo4-op4");
                }

                if (a.GetType().Name.Equals("Television"))
                {
                    ITelevision atv = (ITelevision)a;
                    atv.On();
                    atv.ChangeTVNumber(100);
                }
            });
        }
    }
}
