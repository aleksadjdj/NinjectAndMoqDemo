using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjectAndMoqDemo;
using Moq;

namespace NijectAndMoqDemoTests
{
    [TestClass]
    public class DiscountCalculatorTest
    {

        private IEnumerable<Product> TestProducts2()
        {
            return new[] {
                 new Product { Price = 0, Name = "" },
                new Product { Price = 99, Name = "" }
            };
        }

        [TestMethod]
        public void CalculateDiscount_IfTotalSumPriceIsGreaterThen100_Return10()
        {
            var discountCalculator = new DiscountCalculator();

            var products = new List<Product>
            {
                new Product { Price = 101,  Name = ""  }
            };

            var result = discountCalculator.CalculateDiscount(products);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void CalculateDiscount_IfTotalSumPriceIsLessThen100_Return0()
        {
            var discountCalculator = new DiscountCalculator();

            var result = discountCalculator.CalculateDiscount(TestProducts2());

            Assert.AreEqual(0, result);
        }
    }
}
