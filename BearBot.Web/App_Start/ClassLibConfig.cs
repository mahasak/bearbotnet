using BearBot.Infrastructure.Bot.Metrics;
using Microsoft.Practices.Unity;
using System.Web.Http;

namespace BearBot.Web
{
    public class ClassLibConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IBearBotMetric, BearBotMetric>(new ContainerControlledLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}