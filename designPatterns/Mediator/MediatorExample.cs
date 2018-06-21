using designPatterns.Mediator.Players;

namespace designPatterns.Mediator
{
    /// <summary>
    /// 仲介者
    /// 範例參考來源:
    /// 大話設計模式
    /// http://corrupt003-design-pattern.blogspot.com/2017/01/mediator-pattern.html
    /// https://xyz.cinc.biz/2013/07/mediator-pattern.html
    /// </summary>
    public class MediatorExample : IPatternExample
    {
        public void DoWork()
        {
            Host host = new Host();
            RedPlayer r1 = new RedPlayer("紅1", host);
            RedPlayer r2 = new RedPlayer("紅2", host);
            BluePlayer b1 = new BluePlayer("藍1", host);
            BluePlayer b2 = new BluePlayer("藍2", host);
            GreenPlayer g1 = new GreenPlayer("綠1", host);
            GreenPlayer g2 = new GreenPlayer("綠2", host);
            host.AddPlayer(r1); host.AddPlayer(r2);
            host.AddPlayer(b1); host.AddPlayer(b2);
            host.AddPlayer(g1); host.AddPlayer(g2);

            r1.Kill(b1.id);
            r2.KillAll();
            b1.Blood(b2.id);
            b2.Blood(b1.id);
            g1.Kill(r2.id);
            g2.BloodAll();
            r2.KillAll();
            r2.KillAll();
            r2.KillAll();
            r2.KillAll();
        }
    }
}
