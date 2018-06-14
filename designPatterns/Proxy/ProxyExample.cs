namespace designPatterns.Proxy
{
    /// <summary>
    /// 代理
    /// 範例來源:https://dotblogs.com.tw/alonstar/2011/05/13/25025
    /// </summary>
    public class ProxyExample : IPatternExample
    {
        public void DoWork()
        {
            new ProxyService().DoWork();
        }
    }
}
