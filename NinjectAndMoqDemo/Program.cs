using Ninject;
using NinjectAndMoqDemo.Infrastructure;
using System.Reflection;

namespace NinjectAndMoqDemo
{
    public class Program
    {
        public static void Main()
        {

            var priceCalculator = Container.kernel.Get<IPriceCalculator>();

            System.Console.WriteLine(
                priceCalculator.TotalProductsSum(AbstractProducts.GetProducts())
                );

            var discountCalculator = Container.kernel.Get<IDiscountCalculator>();

            System.Console.WriteLine(
                discountCalculator.CalculateDiscount(AbstractProducts.GetProducts())
            );
        }
    }
}
