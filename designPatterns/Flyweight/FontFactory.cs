using System.Collections;

namespace designPatterns.Flyweight
{
    public class FontFactory
    {
        private Hashtable FontFlyweight;

        public FontFactory()
        {
            FontFlyweight = new Hashtable();
        }

        public Font create(string name, Style style, int size)
        {
            string key = name.ToString() + style.ToString() + size.ToString();

            if (!FontFlyweight.ContainsKey(key))
            {
                Font font = new Font(name, style, size);
                FontFlyweight.Add(key, font);
            }

            return ((Font)FontFlyweight[key]);
        }

        public int GetFactoryCount()
        {
            return FontFlyweight.Count;
        }
    }
}
