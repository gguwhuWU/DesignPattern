using System.Collections.Generic;

namespace designPatterns.Visitor2
{
    public class ObjectStructure : IObjectStructure
    {
        public List<IElement> Elements { get; set; }

        public ObjectStructure()
        {
            this.Elements = new List<IElement>();
        }
        public void Attach(IElement element)
        {
            this.Elements.Add(element);
        }
        public void Detach(IElement element)
        {
            this.Elements.Remove(element);
        }
        public void Accept(IVisitor visitor)
        {
            this.Elements.ForEach(x => x.Accept(visitor));
        }
    }
}
