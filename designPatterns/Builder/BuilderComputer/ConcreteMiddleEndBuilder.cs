namespace designPatterns.Builder.BuilderComputer
{
    public class ConcreteMiddleEndBuilder : IBuilderComputer
    {
        Computer computer = new Computer();

        public void BuildCASE()
        {
            computer.Add("正常機殼");
        }

        public void BuildCPU()
        {
            computer.Add("中階處理器");
        }

        public void BuildHD()
        {
            computer.Add("1T SSD 硬碟");
        }

        public void BuildMainboard()
        {
            computer.Add("B360 主機板");
        }

        public void BuildPSU()
        {
            computer.Add("500W 電源供應器");
        }

        public void BuildRAM()
        {
            computer.Add("16GB 記憶體");
        }

        public void BuildVGA()
        {
            computer.Add("GTX1030 顯示卡");
        }

        public void GetComputer()
        {
            computer.Show();
        }
    }
}
