using System;

namespace designPatterns.Mediator
{
    public abstract class Player
    {
        public string name;
        public string id;

        private Host host;
        public abstract int allBloodNumber { get; internal set; }
        protected abstract int MaxBloodNumber { get;}
        protected abstract int attackNumber { get; }
        protected abstract int magicNumber { get; }
        
        public Player(string name, Host host)
        {
            this.host = host;
            this.name = name;
            this.id = Guid.NewGuid().ToString();
        }
        
        public void Kill(string id)
        {
            host.Kill(id, attackNumber, this);
            Console.WriteLine($"玩家:{name} 殺 編號:{id}");
        }

        public void KillAll()
        {
            host.KillAll(attackNumber, this);
            Console.WriteLine($"玩家:{name} 殺所有人");
        }

        public void Blood(string id)
        {
            host.Blood(id, magicNumber, this);
            Console.WriteLine($"玩家:{name} 補 編號:{id}");
        }

        public void BloodAll()
        {
            host.BloodAll(magicNumber, this);
            Console.WriteLine($"玩家:{name} 補所有人");
        }

        public void Killed(string name, int attackNumber)
        {
            allBloodNumber = allBloodNumber - attackNumber;
            Console.WriteLine($"玩家:{this.name} 被 {name} 扣了 {attackNumber}血，剩下{allBloodNumber}血量");
        }

        public void Blooded(string name, int magicNumber)
        {
            allBloodNumber = allBloodNumber + magicNumber;

            if (allBloodNumber > MaxBloodNumber)
            {
                allBloodNumber = MaxBloodNumber;
                Console.WriteLine($"玩家:{this.name} 血量已達最大值");
            }

            Console.WriteLine($"玩家:{this.name} 被 {name} 補了 {attackNumber}血，還有{allBloodNumber}血量");
        }
    }
}
