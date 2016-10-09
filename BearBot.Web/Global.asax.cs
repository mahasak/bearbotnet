using BearBot.Infrastructure.Bot.Control;
using BearBot.Infrastructure.Bot.Job;
using Metrics;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity;
using BearBot.Infrastructure.Bot.Metrics;
using System.Configuration;

namespace BearBot.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalConfiguration.Configure(ClassLibConfig.Register);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Metric.Config
                .WithHttpEndpoint("http://localhost:1234/")
                .WithAllCounters();
            var bearbotMetrics = UnityConfig.GetConfiguredContainer().Resolve<IBearBotMetric>();
            BearSlaveMaster.Roar(bearbotMetrics, Convert.ToInt32(ConfigurationManager.AppSettings["botInterval"]));
        }
    }
}
