using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using NinjectAndMoqDemo;
using NinjectAndMoqDemo.Infrastructure;
using System.Collections.Generic;

namespace NijectAndMoqDemoTests
{
    [TestClass]
    public class PriceCalculatorTest
    {
        [TestMethod]
        public void TotalProductsSum_IfSumIsGreaterThen100_ReturnsTotalSumMinus10()
        {
            var priceCalculator = Container.kernel.Get<IPriceCalculator>();

            var list = new List<Product>
            { new Product { Price = 101, Name = "test" } };

            var result = priceCalculator.TotalProductsSum(list);

            Assert.AreEqual(91, result);
        }
        
        [TestMethod]
        public void TotalProductsSum_IfSumIsLessThenOrEqual100_ReturnsSum()
        {
            var priceCalculator = Container.kernel.Get<IPriceCalculator>();

            var list = new List<Product>
            { new Product { Price = 100, Name = "test" } };

            var result = priceCalculator.TotalProductsSum(list);

            Assert.AreEqual(100, result);
        }

    }
}
