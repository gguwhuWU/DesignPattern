namespace designPatterns.Adapter.Interface
{
    public interface IDehumidifier : IAppliance
    {
        void ChangeNormalDehumidifier();

        void ChangeStrongDehumidifier();

        void ChangeWeakDehumidifier();
    }
}
