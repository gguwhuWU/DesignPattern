using designPatterns.Visitor2.Visitors;
using System.Collections.Generic;
using System.Linq;

namespace designPatterns.Visitor2
{
    /// <summary>
    /// 訪問者2
    /// 範例來源:
    /// https://ithelp.ithome.com.tw/articles/10196407
    /// </summary>
    public class Visitor2Example : IPatternExample
    {
        public void DoWork()
        {
            List<IElement> Shopcart = new List<IElement>(){
                new Product { ProductType=ProductTypeEnum.Book, Name="設計模式的解析與活用", UnitPrice=480, Amount=20 },
                new Product { ProductType=ProductTypeEnum.Book, Name="使用者故事對照", UnitPrice=580, Amount=5 }
            };

            IObjectStructure checkout = new ObjectStructure();

            //checkout.Attach(Shopcart[0]);
            //checkout.Attach(Shopcart[1]);

            Shopcart.Where(item=>item.ProductType.Equals(ProductTypeEnum.Book)).ToList().ForEach(item => {
                checkout.Attach(item);
            });
            
            checkout.Accept(new VisitorDiscount4Count());

            checkout.Accept(new VisitorDiscount4TotalPrice());
        }
    }
}
