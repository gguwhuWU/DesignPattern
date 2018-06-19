using System;

namespace designPatterns.Command.Character
{
    public class Saber : ICharacter
    {
        public string Name
        {
            get
            {
                return "劍士";
            }
        }

        public int MaxRange
        {
            get
            {
                return 2;
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

        public Saber()
        {
            maxTrickNumber = 4;
        }

        public void Attack()
        {
            Console.WriteLine($"{Name}對距離1內的目標打出1傷害");
        }

        public void Trick()
        {
            Console.WriteLine($"{Name}對距離2內的目標打出2傷害");
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
