using System;

namespace designPatterns.Command.Character
{
    public class Mage : ICharacter
    {
        public string Name
        {
            get
            {
                return "法師";
            }
        }

        public int MaxRange
        {
            get
            {
                return 1;
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

        public Mage()
        {
            maxTrickNumber = 3;
        }
        
        public void Attack()
        {
            Console.WriteLine($"{Name}對距離3內的目標打出3傷害");
        }

        public void Trick()
        {
            Console.WriteLine($"{Name}對距離3內的目標打出6傷害");
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
