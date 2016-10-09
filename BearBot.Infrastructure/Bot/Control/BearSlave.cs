using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Narrator.Framework;
using BearBot.Infrastructure.Bot.Metrics;
using Microsoft.Practices.Unity;
using BearBot.Infrastructure.App_Start;

namespace BearBot.Infrastructure.Bot.Control
{
    public class BearSlave
    {
       IBearBotMetric bearbotMetric;

        public BearSlave()
        {
            // var _container = new UnityContainer();
            //this.bearbotMetric = _container.Resolve<IBearBotMetric>();
            this.bearbotMetric = UnityConfig.GetConfiguredContainer().Resolve<IBearBotMetric>();
        }

        public string run(string scenarioName, string features)
        {
            var message = "";
            bearbotMetric.markOnTestStart(scenarioName);
            try
            {
                features.ExecuteText();
                bearbotMetric.markOnTestPass(scenarioName);
                message = "success";
            }
            catch (Exception e)
            {
                bearbotMetric.markOnTestFailed(scenarioName);
                message = e.Message;
            }
            bearbotMetric.markOnTestfinish(scenarioName);
            return message;
        }
    }
}
