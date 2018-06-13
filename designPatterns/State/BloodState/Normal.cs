using System;

namespace designPatterns.State.BloodState
{
    public class Normal : IState
    {
        Person person;

        public Normal(Person person)
        {
            this.person = person;
        }

        public void Attack()
        {
            Console.WriteLine($"打出 {person.attackNumber * 10} 傷害");
        }

        public void Move()
        {
            Console.WriteLine($"移動 {person.moveNumber * 5} 距離");
        }

        public void StateChangeCheck()
        {
            decimal BloodPercent = person.blood / 100;

            if ((decimal)0.85 < BloodPercent && BloodPercent <= 1)
            {
                Console.WriteLine("目前身體良好!"); Console.WriteLine();
            }
            else if (BloodPercent > 1)
            {
                person.state = new Zoe(person);
                person.state.StateChangeCheck();
            }
            else
            {
                person.state = new Tired(person);
                person.state.StateChangeCheck();
            }
        }

        public void SupplyBlood()
        {
            decimal BloodPercent = person.blood / 100;
            if (BloodPercent < 1)
            {
                dynamic supplyNumber = person.MaxBlood * (decimal)0.1;
                Console.WriteLine($"恢復 {supplyNumber} 血量");
                person.blood = person.blood + (int)supplyNumber;
            }
            else
            {
                Console.WriteLine($"不需要恢復血量");
            }
            
        }
    }
}
