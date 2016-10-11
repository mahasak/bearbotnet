using BearBot.Infrastructure.Bot.Metrics;
using BearBot.Infrastructure.Service;
using BearBot.Infrastructure.Service.Interface;
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
            container.RegisterType<IBearMasterService, BearMasterService>();
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}