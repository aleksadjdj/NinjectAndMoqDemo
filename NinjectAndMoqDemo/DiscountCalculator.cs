using System.Collections.Generic;
using System.Linq;

namespace NinjectAndMoqDemo
{
    public class DiscountCalculator : IDiscountCalculator
    {
        public int CalculateDiscount(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price) > 100 ? 10 : 0;
        }
    }
}
