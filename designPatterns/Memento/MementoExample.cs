namespace designPatterns.Memento
{
    /// <summary>
    /// 備忘錄(存檔/暫存)
    /// 範例參考來源:
    /// 大話設計模式
    /// http://corrupt003-design-pattern.blogspot.com/2017/02/memento-pattern.html
    /// https://xyz.cinc.biz/2013/07/memento-pattern.html
    /// </summary>
    public class MementoExample : IPatternExample
    {
        public void DoWork()
        {
            // 創造一個遊戲角色
            GamePlayer player = new GamePlayer("jojo", 100, 80, 0);
            player.ShowState();

            // 存檔
            GameCaretaker caretaker = new GameCaretaker();
            caretaker.setMemento("s1", player.saveToMemento());

            // 打小怪1
            player.play(-10, -10, 10);
            player.ShowState();
            caretaker.setMemento("s2", player.saveToMemento());
            //故意重複檔名
            caretaker.setMemento("s2", player.saveToMemento());

            // 打小怪2
            player.play(-10, -10, 10);
            player.ShowState();
            caretaker.setMemento("s3", player.saveToMemento());

            // 打小怪3
            player.play(-10, -10, 10);
            player.ShowState();
            caretaker.setMemento("s4", player.saveToMemento());
            caretaker.removeMemento("s1");
            caretaker.setMemento("s4", player.saveToMemento());

            // 打boss
            player.play(-70, -30, -30);
            player.ShowState();

            // 重新讀取存檔
            player.restoreFromMemento(caretaker.getMemento("s1"));
            player.restoreFromMemento(caretaker.getMemento("s3"));
            player.ShowState();
            player.restoreFromMemento(caretaker.getMemento("s4"));
            player.ShowState();

            caretaker.ShowMementos();
        }
    }
}
