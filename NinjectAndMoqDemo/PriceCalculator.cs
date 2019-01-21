using System.Collections.Generic;
using System.Linq;

namespace NinjectAndMoqDemo
{
    public class PriceCalculator : IPriceCalculator
    {
        private readonly IDiscountCalculator _iscountCalculator;

        public PriceCalculator(IDiscountCalculator iscountCalculator)
        {
            _iscountCalculator = iscountCalculator;
        }

        public int TotalProductsSum(IEnumerable<Product> products)
        {
            return (products.Sum(p => p.Price) 
                - _iscountCalculator.CalculateDiscount(products));
        }
    }
}
