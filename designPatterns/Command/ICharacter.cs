namespace designPatterns.Command
{
    /// <summary>
    /// 執行命令的物件 (receiver)
    /// </summary>
    public interface ICharacter
    {
        string Name { get; }
        int MaxRange { get; }
        int MaxTrickNumber { get; set; }
        void Attack();
        void Trick();
        void MoveLeft(int distance);
        void MoveRight(int distance);
        void MoveFront(int distance);
        void MoveBack(int distance);
    }
}
