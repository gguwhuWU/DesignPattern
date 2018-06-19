namespace designPatterns.Command
{
    /// <summary>
    /// 命令的物件 (command)
    /// </summary>
    public interface ICommand
    {
        void ExcuteCommand();
        bool CheckCommand();
    }
}
