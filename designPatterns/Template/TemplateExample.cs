namespace designPatterns.Template
{
    /// <summary>
    /// 範本
    /// 範例來源:大話設計模式
    /// </summary>
    public class TemplateExample : IPatternExample
    {
        public void DoWork()
        {
            TestPaperA ta = new TestPaperA();
            ta.DisplayName();
            ta.TestQuestion1();
            ta.TestQuestion2();
            ta.TestQuestion3();

            TestPaperB tb = new TestPaperB();
            tb.DisplayName();
            tb.TestQuestion1();
            tb.TestQuestion2();
            tb.TestQuestion3();
        }
    }
}
