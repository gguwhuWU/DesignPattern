using System;

namespace designPatterns.State.BloodState
{
    public class Tired : IState
    {
        Person person;

        public Tired(Person person)
        {
            this.person = person;
        }

        public void Attack()
        {
            Console.WriteLine($"打出 {person.attackNumber * 7} 傷害");
        }

        public void Move()
        {
            Console.WriteLine($"移動 {person.moveNumber * 3} 距離");
        }

        public void StateChangeCheck()
        {
            decimal BloodPercent = person.blood / 100;

            if ((decimal)0.3 < BloodPercent && BloodPercent <= (decimal)0.85)
            {
                Console.WriteLine("目前身體很疲累!"); Console.WriteLine();
            }
            else if (BloodPercent > (decimal)0.85)
            {
                person.state = new Normal(person);
                person.state.StateChangeCheck();
            }
            else
            {
                person.state = new Exhaustion(person);
                person.state.StateChangeCheck();
            }
        }

        public void SupplyBlood()
        {
            dynamic supplyNumber = person.MaxBlood * (decimal)0.2;
            Console.WriteLine($"恢復 {supplyNumber} 血量");
            person.blood = person.blood + (int)supplyNumber;
        }
    }
}
