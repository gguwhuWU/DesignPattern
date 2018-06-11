namespace designPatterns.Builder
{
    public class Director
    {
        public void Construct(IBuilderComputer builder)
        {
            builder.BuildCASE();
            builder.BuildCPU();
            builder.BuildHD();
            builder.BuildMainboard();
            builder.BuildPSU();
            builder.BuildRAM();
            builder.BuildVGA();
        }
    }
}
