namespace designPatterns.Singleton
{
    /// <summary>
    /// 餓漢式獨體
    /// sealed 阻止被繼承
    /// </summary>
    public sealed class StartObject
    {
        /// <summary>
        /// 初始化就建立
        /// </summary>
        private readonly static StartObject instance = new StartObject();

        /// <summary>
        /// 讓外部程式碼不能直接new來實體化它
        /// </summary>
        private StartObject()
        {
        }

        public static StartObject GetInstance()
        {
            return instance;
        }
    }
}
