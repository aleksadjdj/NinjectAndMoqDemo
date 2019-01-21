using Ninject;
using Ninject.Modules;

namespace NinjectAndMoqDemo.Infrastructure
{
    public static class Container
    {
        public static readonly IKernel kernel = new StandardKernel(new Bindings());

        private class Bindings : NinjectModule
        {
            public override void Load()
            {
                Bind<IDiscountCalculator>().To<DiscountCalculator>();
                Bind<IPriceCalculator>().To<PriceCalculator>();
            }
        }
    }
}
