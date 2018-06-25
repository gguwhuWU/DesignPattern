namespace designPatterns.Visitor2
{
    public class Product : IElement
    {
        public ProductTypeEnum ProductType { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
