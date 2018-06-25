namespace designPatterns.Interpreter
{
    /// <summary>
    /// 存放待解譯資料
    /// </summary>
    public class Context
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
