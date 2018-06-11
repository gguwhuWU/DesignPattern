using System;

namespace designPatterns.Template
{
    public abstract class TestPaper
    {
        protected virtual string Name { get; }

        public void DisplayName()
        {
            Console.WriteLine($"學生名稱: {Name}");
        }

        public void TestQuestion1()
        {
            Console.WriteLine("問題一:12321312312331321");
            Console.WriteLine($"答案: {Answer1()}");
        }

        public void TestQuestion2()
        {
            Console.WriteLine("問題二:12321312312331321");
            Console.WriteLine($"答案: {Answer2()}");
        }

        public void TestQuestion3()
        {
            Console.WriteLine("問題三:12321312312331321");
            Console.WriteLine($"答案: {Answer3()}");
        }

        protected abstract string Answer1();

        protected abstract string Answer2();

        protected virtual string Answer3()
        {
            return string.Empty;
        }
    }
}
