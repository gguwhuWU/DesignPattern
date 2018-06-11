namespace designPatterns.Template
{
    public class TestPaperB : TestPaper
    {
        protected override string Name
        {
            get { return "小華"; }
        }

        protected override string Answer1()
        {
            return "C";
        }

        protected override string Answer2()
        {
            return "D";
        }

        protected override string Answer3()
        {
            return "B";
        }
    }
}
