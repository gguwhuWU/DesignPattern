namespace designPatterns.Bridge.Control
{
    public interface IState
    {
        void NextState(IRemoteControl control);
    }
}
