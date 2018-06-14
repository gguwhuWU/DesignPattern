namespace designPatterns.Adapter.Interface
{
    public interface ISound : IAppliance
    {
        void ChangeCDNumber(string CDName);
    }
}
