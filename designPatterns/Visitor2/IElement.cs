namespace designPatterns.Visitor2
{
    public interface IElement
    {
        ProductTypeEnum ProductType { get; set; }
        string Name { get; set; }
        decimal UnitPrice { get; set; } //單價
        int Amount { get; set; } //購買總數
        decimal TotalPrice { get; set; }
        void Accept(IVisitor visitor);
    }
}
