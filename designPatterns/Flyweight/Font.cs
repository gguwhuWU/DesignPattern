using System;

namespace designPatterns.Flyweight
{
    public class Font
    {
        private string name;
        private Style style;
        private int size;

        public Font(string name, Style style, int size)
        {
            this.name = name;
            this.style = style;
            this.size = size;
        }

        public bool equals(Object other)
        {
            
            if (other is Font) {
                if (other == this)
                {
                    return true;
                }

                Font font = (Font)other;

                return font.style == style
                       && font.size == size
                       && font.name.Equals(this.name);
            }

            return false;
        }

        public int hashCode()
        {
            return ((int)style * 37 + size * 13) * name.GetHashCode();
        }
    }
}
