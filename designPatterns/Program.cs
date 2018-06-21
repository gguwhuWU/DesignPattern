﻿using System;

namespace designPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            PatternExampleContext patternExample = new PatternExampleContext();
            patternExample.DoPatternExample(PatternType.Mediator);

            Console.ReadLine();
        }
    }
}
