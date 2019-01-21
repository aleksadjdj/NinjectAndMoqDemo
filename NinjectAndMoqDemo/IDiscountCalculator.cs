using System.Collections.Generic;

namespace NinjectAndMoqDemo
{
    public interface IDiscountCalculator
    {
        int CalculateDiscount(IEnumerable<Product> products);
    }
}