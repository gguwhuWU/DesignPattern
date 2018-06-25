using System;

namespace designPatterns.Visitor2.Visitors
{
    public class VisitorDiscount4TotalPrice : IVisitor
    {
        public void Visit(IElement elm)
        {
            var totalPrice = elm.UnitPrice * (decimal)elm.Amount;
            if (totalPrice > 1000)
            {
                elm.TotalPrice = totalPrice * 0.9M;
                Console.WriteLine($"(折扣!){elm.Name}: 單價${elm.UnitPrice}, 數量{elm.Amount}, 10% off, 總價格={elm.TotalPrice} ");
            }
            else
            {
                elm.TotalPrice = totalPrice;
                Console.WriteLine($"{elm.Name}: 單價${elm.UnitPrice}, 數量{elm.Amount}, 總價格={elm.TotalPrice} ");
            }
        }
    }
}
