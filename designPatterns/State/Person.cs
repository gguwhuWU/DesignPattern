using designPatterns.State.BloodState;

namespace designPatterns.State
{
    public class Person
    {
        public IState state;
        public readonly decimal MaxBlood;
        public decimal blood;
        public int attackNumber;
        public int moveNumber;

        public Person(decimal blood = 100, int attackNumber = 10, int moveNumber = 10)
        {
            this.blood = blood;
            this.MaxBlood = blood;
            this.attackNumber = attackNumber;
            this.moveNumber = moveNumber;
            state = new Normal(this);
        }

        public void Attack()
        {
            state.StateChangeCheck();
            state.Attack();
        }

        public void Move()
        {
            state.StateChangeCheck();
            state.Move();
        }

        public void SupplyBlood()
        {
            state.StateChangeCheck();
            state.SupplyBlood();
        }
    }
}
