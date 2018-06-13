using System;

namespace designPatterns.State.BloodState
{
    public class Zoe : IState
    {
        Person person;

        public Zoe(Person person)
        {
            this.person = person;
        }

        public void Attack()
        {
            Console.WriteLine($"打出 {person.attackNumber * 15} 傷害");
            person.blood = person.blood - (int)(person.blood * (decimal)0.1);
        }

        public void Move()
        {
            Console.WriteLine($"移動 {person.moveNumber * 8} 距離");
            person.blood = person.blood - (int)(person.blood * (decimal)0.1);
        }

        public void StateChangeCheck()
        {
            decimal BloodPercent = person.blood / 100;

            if (1 < BloodPercent)
            {
                Console.WriteLine("目前進入零的領域!"); Console.WriteLine();
            }
            else
            {
                person.state = new Normal(person);
                person.state.StateChangeCheck();
            }
        }

        public void SupplyBlood()
        {
            Console.WriteLine($"無法恢復血量");
        }
    }
}
