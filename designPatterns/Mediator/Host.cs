using System;
using System.Collections.Generic;
using System.Linq;

namespace designPatterns.Mediator
{
    public class Host
    {
        private IList<Player> players;
        public Host()
        {
            this.players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void Kill(string id, int attackNumber, Player player)
        {
            var pr = players.Where(p => p.id.Equals(id)).SingleOrDefault();
            pr.Killed(player.name, attackNumber);

            if (pr.allBloodNumber <= 0)
            {
                players.Remove(pr);
                Console.WriteLine($"{pr.name} 已死亡，退出遊戲!");
            }
        }

        public void KillAll(int attackNumber, Player player)
        {
            var removeList = new List<Player>();
            foreach (var p in players)
            {
                if (p.GetType() == player.GetType())
                {
                    continue;
                }

                p.Killed(player.name, attackNumber);

                if (p.allBloodNumber <= 0)
                {
                    removeList.Add(p);
                   
                }
            }

            foreach (var p in removeList)
            {
                players.Remove(p);
                Console.WriteLine($"{p.name} 已死亡，退出遊戲!");
            }
        }

        public void Blood(string id, int MagicNumber, Player player)
        {
            players.Where(p => p.id.Equals(id)).SingleOrDefault().Blooded(player.name, MagicNumber);
        }

        public void BloodAll(int MagicNumber, Player player)
        {
            foreach(var p in players)
            {
                if (p == player)
                {
                    continue;
                }

                p.Blooded(player.name, MagicNumber);
            }
        }
    }
}
