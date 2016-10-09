using Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Infrastructure.Bot.Metrics
{
    public class BearBotMetric : IBearBotMetric
    {
        private static readonly  Counter scenarioStart = Metric.Counter("scenarioStart", Unit.Calls);

        private static readonly Counter scenarioPass = Metric.Counter("scenarioPass", Unit.Calls);

        private static readonly Counter scenarioFailed = Metric.Counter("scenarioFailed", Unit.Calls);

        private static readonly Counter scenarioFinished = Metric.Counter("scenarioFinished", Unit.Calls);

        public  void markOnTestFailed(string item)
        {
            scenarioFailed.Increment(item);
        }

        public  void markOnTestfinish(string item)
        {
            scenarioFinished.Increment(item);
        }

        public  void markOnTestPass(string item)
        {
            scenarioPass.Increment(item);
        }

        public  void markOnTestStart(string item)
        {
            scenarioStart.Increment(item);
        }
    }
}
