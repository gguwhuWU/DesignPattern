namespace designPatterns.State
{
    /// <summary>
    /// 狀態
    /// 範例參考來源:
    /// 大話設計模式
    /// https://xyz.cinc.biz/2013/07/state-pattern.html
    /// https://dotblogs.com.tw/pin0513/2011/01/16/20842
    /// </summary>
    public class StateExample : IPatternExample
    {
        public void DoWork()
        {
            Person person = new Person(200, 20, 30);
            person.Attack();
            person.Move();
            person.SupplyBlood();

            person.blood = 60;
            person.Attack();
            person.Move();
            person.SupplyBlood();

            person.blood = 2;
            person.Attack();
            person.Move();
            person.SupplyBlood();

            person.blood = 150;
            person.Attack();
            person.Move();
            person.SupplyBlood();
        }
    }
}
