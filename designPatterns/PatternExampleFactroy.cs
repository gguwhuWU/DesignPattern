using System.Reflection;

namespace designPatterns
{
    public class PatternExampleContext
    {
        public void DoPatternExample(PatternType patternType)
        {
            string patternTypeName = patternType.ToString();
            IPatternExample patternExample = (IPatternExample)Assembly.Load("designPatterns").CreateInstance($"designPatterns.{patternTypeName}.{patternTypeName}Example");
            patternExample.DoWork();
        }
    }
}
