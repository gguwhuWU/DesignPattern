using System;

namespace designPatterns.OOP
{
    public class CatShoutEventArgs2 : EventArgs
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
