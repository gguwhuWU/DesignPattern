namespace designPatterns.Adapter.Interface
{
    public interface IAirPurifier : IAppliance
    {
        void ChangeStrongPurifier();
        void ChangeNormalPurifier();
        void ChangeWeakPurifier();
    }
}
