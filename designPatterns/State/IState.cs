namespace designPatterns.State
{
    public interface IState
    {
        void StateChangeCheck();
        void Attack();
        void Move();
        void SupplyBlood();
    }
}
