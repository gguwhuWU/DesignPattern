namespace designPatterns.Builder.BuilderComputer
{
    public class ConcreteHighEndBuilder : IBuilderComputer
    {
        Computer computer = new Computer();

        public void BuildCASE()
        {
            computer.Add("電競專用機殼");
        }

        public void BuildCPU()
        {
            computer.Add("高階處理器");
        }

        public void BuildHD()
        {
            computer.Add("2T SSD 硬碟");
        }

        public void BuildMainboard()
        {
            computer.Add("H370 主機板");
        }

        public void BuildPSU()
        {
            computer.Add("600W 電源供應器");
        }

        public void BuildRAM()
        {
            computer.Add("32GB 記憶體");
        }

        public void BuildVGA()
        {
            computer.Add("GTX1080 顯示卡");
        }

        public void GetComputer()
        {
            computer.Show();
        }
    }
}
