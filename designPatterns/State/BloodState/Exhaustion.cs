using System;

namespace designPatterns.State.BloodState
{
    public class Exhaustion : IState
    {
        Person person;

        public Exhaustion(Person person)
        {
            this.person = person;
        }

        public void Attack()
        {
            Console.WriteLine($"打出 {person.attackNumber * 3} 傷害");
        }

        public void Move()
        {
            Console.WriteLine($"移動 {person.moveNumber * 1} 距離");
        }

        public void StateChangeCheck()
        {
            decimal BloodPercent = person.blood / 100;

            if (BloodPercent <= (decimal)0.3)
            {
                Console.WriteLine("目前身體快崩潰!"); Console.WriteLine();
            }
            else
            {
                person.state = new Tired(person);
                person.state.StateChangeCheck();
            }
        }

        public void SupplyBlood()
        {
            dynamic supplyNumber = person.MaxBlood * (decimal)0.3;
            Console.WriteLine($"恢復 {supplyNumber} 血量");
            person.blood = person.blood + (int)supplyNumber;
        }
    }
}
