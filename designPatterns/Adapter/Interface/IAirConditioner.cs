namespace designPatterns.Adapter.Interface
{
    public interface IAirConditioner : IAppliance
    {
        void ChangeStrongAirvolume();
        void ChangeNormalAirvolume();
        void ChangeWeakAirvolume();
    }
}
