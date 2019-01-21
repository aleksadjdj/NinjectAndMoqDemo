using System.Collections.Generic;

namespace NinjectAndMoqDemo
{
    public static class AbstractProducts
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new []
            {
                new Product{ Price = 10, Name = "pt.1" },
                new Product{ Price = 20, Name = "pt.2" },
                new Product{ Price = 30, Name = "pt.3" },
                new Product{ Price = 50, Name = "pt.4" },
            };
        }
    }
}
