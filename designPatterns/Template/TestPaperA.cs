namespace designPatterns.Template
{
    public class TestPaperA : TestPaper
    {
        protected override string Name
        {
            get { return "小明"; }
        }

        protected override string Answer1()
        {
            return "A";
        }

        protected override string Answer2()
        {
            return "D";
        }

        protected override string Answer3()
        {
            return "C";
        }
    }
}
