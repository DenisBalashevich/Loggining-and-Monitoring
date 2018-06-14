using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MvcMusicStore.Infrastucture;
using MvcMusicStore.Logger;
using PerformanceCounterHelper;

namespace MvcMusicStore
{
    public class AutofacConfig
    {
        public static IDependencyResolver ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.Register(c => PerformanceHelper.CreateCounterHelper<Counters>()).SingleInstance().As<CounterHelper<Counters>>();
            builder.RegisterType<Logger.Logger>().As<ILogger>();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            return new AutofacDependencyResolver(container);
        }

    }
}