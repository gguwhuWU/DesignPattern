using designPatterns.Command.Character;
using designPatterns.Command.Commands;

namespace designPatterns.Command
{
    /// <summary>
    /// 命令
    /// 範例參考來源:
    /// 大話設計模式
    /// http://goodmanroc.blogspot.com/2011/06/design-patterns-command.html
    /// https://xyz.cinc.biz/2013/07/command-pattern.html
    /// https://dotblogs.com.tw/ricochen/2012/08/03/73801
    /// </summary>
    public class CommandExample : IPatternExample
    {
        public void DoWork()
        {
            // 要發出命令的人
            Player playerA = new Player("小林");
            Player playerB = new Player("小陳");

            //被命令要去執行的物件
            Archer archerByA = new Archer();
            Archer archerByB = new Archer();
            Mage mageByA = new Mage();
            Mage mageByB = new Mage();
            Knight knight = new Knight();
            Saber saber = new Saber();

            //塞入命令
            playerA.SetCommand(new MoveFrontCommand(knight, 3));
            playerA.SetCommand(new MoveFrontCommand(knight, 8));
            playerA.SetCommand(new MoveLeftCommand(mageByA, 1));
            playerA.SetCommand(new MoveBackCommand(mageByA, 1));
            playerA.SetCommand(new MoveRightCommand(archerByA, 1));
            playerA.SetCommand(new TrickCommand(archerByA));
            playerA.SetCommand(new TrickCommand(archerByA));
            playerA.SetCommand(new TrickCommand(archerByA));
            playerA.SetCommand(new TrickCommand(archerByA));
            playerA.SetCommand(new AttackCommand(mageByA));
           
            playerB.SetCommand(new MoveFrontCommand(saber, 1));
            playerB.SetCommand(new TrickCommand(archerByB));
            playerB.SetCommand(new AttackCommand(archerByB));
            playerB.CancelCommand(new AttackCommand(mageByB));
            playerB.SetCommand(new TrickCommand(mageByB));

            playerA.Notify();
            playerB.Notify();

            playerA.SetCommand(new TrickCommand(mageByA));
            playerB.SetCommand(new TrickCommand(mageByB));

            playerA.Notify();
            playerB.Notify();
        }
    }
}
