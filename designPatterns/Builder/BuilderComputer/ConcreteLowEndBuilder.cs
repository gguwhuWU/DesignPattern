namespace designPatterns.Builder.BuilderComputer
{
    public class ConcreteLowEndBuilder : IBuilderComputer
    {
        Computer computer = new Computer();

        public void BuildCASE()
        {
            computer.Add("不起眼的機殼");
        }

        public void BuildCPU()
        {
            computer.Add("低階處理器");
        }

        public void BuildHD()
        {
            computer.Add("1T 傳統硬碟");
        }

        public void BuildMainboard()
        {
            computer.Add("H310 主機板");
        }

        public void BuildPSU()
        {
            computer.Add("450W 電源供應器");
        }

        public void BuildRAM()
        {
            computer.Add("4GB 記憶體");
        }

        public void BuildVGA()
        {
            computer.Add("內顯");
        }

        public void GetComputer()
        {
            computer.Show();
        }
    }
}
