namespace designPatterns.Facade
{
    /// <summary>
    /// 外觀
    /// 範例來源:大話設計模式
    /// </summary>
    public class FacadeExample : IPatternExample
    {
        public void DoWork()
        {
            FacadeSystem fa = new FacadeSystem();
            fa.MethodA();
            fa.MethodB();
        }
    }
}
