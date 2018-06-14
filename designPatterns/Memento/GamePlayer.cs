using System;

namespace designPatterns.Memento
{
    // Originator
    public class GamePlayer
    {

        // 遊戲角色的生命值
        private int hp;
        // 遊戲角色的魔力值
        private int mp;
        // 遊戲角色的經驗值
        private int exp;
        private string name;

        public GamePlayer(string name, int hp, int mp, int exp)
        {
            this.name = name;
            this.hp = hp;
            this.mp = mp;
            this.exp = exp;
        }

        public GameMemento saveToMemento()
        {
            return new GameMemento(hp, mp, exp);
        }

        public void restoreFromMemento(GameMemento memento)
        {
            if (memento != null)
            {
                hp = memento.getGameHp();
                mp = memento.getGameMp();
                exp = memento.getGameExp();
            }
        }

        public void play(int hp, int mp, int exp)
        {
            this.hp = this.hp + hp;
            this.mp = this.mp + mp;
            this.exp = this.exp + exp;
        }

        public void ShowState()
        {
            Console.WriteLine($"角色:{name}目前->生命值:{hp},魔力值:{mp},經驗值:{exp}");
        }
    }
}
