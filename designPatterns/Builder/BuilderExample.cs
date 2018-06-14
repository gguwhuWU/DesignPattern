using designPatterns.Builder.BuilderComputer;

namespace designPatterns.Builder
{
    /// <summary>
    /// 建造者
    /// 範例參考來源:
    /// http://www.cnblogs.com/zhili/p/BuilderPattern.html
    /// https://blog.csdn.net/carson_ho/article/details/54910597
    /// </summary>
    public class BuilderExample : IPatternExample
    {
        public void DoWork()
        {
            ConcreteHighEndBuilder highEndBuilder = new ConcreteHighEndBuilder();
            ConcreteMiddleEndBuilder middleEndBuilder = new ConcreteMiddleEndBuilder();
            ConcreteLowEndBuilder lowEndBuilder = new ConcreteLowEndBuilder();

            Director director = new Director();
            director.Construct(highEndBuilder);
            director.Construct(middleEndBuilder);
            director.Construct(lowEndBuilder);

            highEndBuilder.GetComputer();
            middleEndBuilder.GetComputer();
            lowEndBuilder.GetComputer();
        }
    }
}
