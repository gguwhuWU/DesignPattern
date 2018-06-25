using System.Collections.Generic;

namespace designPatterns.Visitor2
{
    public interface IObjectStructure
    {
        List<IElement> Elements { get; set; }
        void Attach(IElement element);
        void Detach(IElement element);
        void Accept(IVisitor visitor);
    }
}
