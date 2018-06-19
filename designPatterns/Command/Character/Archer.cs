using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns.Command.Character
{
    public class Archer : ICharacter
    {
        public string Name
        {
            get
            {
                return "弓箭手";
            }
        }

        public int MaxRange
        {
            get
            {
                return 3;
            }
        }

        private int maxTrickNumber;
        public int MaxTrickNumber
        {
            get
            {
                return maxTrickNumber;
            }

            set
            {
                maxTrickNumber = value;
            }
        }

        public Archer()
        {
            maxTrickNumber = 3;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name}對距離2內的目標打出4傷害");
        }

        public void Trick()
        {
            Console.WriteLine($"{Name}對距離5內的目標打出5傷害");
            maxTrickNumber--;
        }

        public void MoveBack(int distance)
        {
            Console.WriteLine($"{Name}往後移動{distance}步");
        }

        public void MoveFront(int distance)
        {
            Console.WriteLine($"{Name}往前移動{distance}步");
        }

        public void MoveLeft(int distance)
        {
            Console.WriteLine($"{Name}往左移動{distance}步");
        }

        public void MoveRight(int distance)
        {
            Console.WriteLine($"{Name}往右移動{distance}步");
        }
    }
}
