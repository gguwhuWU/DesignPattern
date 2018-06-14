namespace designPatterns.Memento
{
    // Memento
    public class GameMemento
    {

        // 假設只有這三個資料要保留
        private int mGameHp;
        private int mGameMp;
        private int mGameExp;

        public GameMemento(int hp, int mp, int exp)
        {
            mGameHp = hp;
            mGameMp = mp;
            mGameExp = exp;
        }

        public int getGameHp()
        {
            return mGameHp;
        }

        public int getGameMp()
        {
            return mGameMp;
        }

        public int getGameExp()
        {
            return mGameExp;
        }
    }
}
