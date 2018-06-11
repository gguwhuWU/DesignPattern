namespace designPatterns.Builder
{
    public interface IBuilderComputer
    {
        /// <summary>
        /// 處理器
        /// </summary>
        void BuildCPU();

        /// <summary>
        /// 主機板
        /// </summary>
        void BuildMainboard();

        /// <summary>
        /// 硬碟
        /// </summary>
        void BuildHD();

        /// <summary>
        /// 記憶體
        /// </summary>
        void BuildRAM();

        /// <summary>
        /// 顯示卡
        /// </summary>
        void BuildVGA();

        /// <summary>
        /// 電源供應器
        /// </summary>
        void BuildPSU();

        /// <summary>
        /// 機殼
        /// </summary>
        void BuildCASE();

        /// <summary>
        /// 獲得組裝完的電腦
        /// </summary>
        void GetComputer();
    }
}
