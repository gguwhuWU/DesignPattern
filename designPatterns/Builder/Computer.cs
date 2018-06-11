using System;
using System.Collections.Generic;

namespace designPatterns.Builder
{
    public class Computer
    {
        private IList<string> parts = new List<string>();
            
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach(var part in parts)
            {
                Console.WriteLine($"組件 {part} 已安裝");
            }

            Console.WriteLine("電腦組裝完成!");
        }
    }
}
