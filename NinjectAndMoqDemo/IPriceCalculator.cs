using System.Collections.Generic;

namespace NinjectAndMoqDemo
{
    public interface IPriceCalculator
    {
        int TotalProductsSum(IEnumerable<Product> products);
    }
}