namespace designPatterns.Singleton
{
    /// <summary>
    /// 拖延實體化 (Lazy instaniaze) 
    /// 懶漢式(飽漢式)獨體類別
    /// </summary>
    public class LazyObject
    {
        private static LazyObject instance;
        private static readonly object syncRoot = new object();

        /// <summary>
        /// 讓外部程式碼不能直接new來實體化它
        /// </summary>
        private LazyObject()
        {
        }

        /// <summary>
        /// 拿取實體化物件
        /// </summary>
        /// <returns></returns>
        public static LazyObject GetInstance()
        {
            if (instance == null)
            {
                instance = new LazyObject();
            }

            return instance;
        }

        /// <summary>
        /// Double-Checked Locking (多執行緒情況下)
        /// 拿取實體化物件
        /// </summary>
        /// <returns></returns>
        public static LazyObject GetInstanceBySync()
        {
            if (instance == null)
            {
                // 防範多執行緒的情況，確保不會同時進入而造成產生多物件
                lock (syncRoot)
                {
                    // 確保只會實體化一次，實體化過的就直接返回
                    if (instance == null)
                    {
                        instance = new LazyObject();
                    }
                }
            }

            return instance;
        }
    }
}
