using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Infrastructure.Bot.Metrics
{
    public interface IBearBotMetric
    {
        void markOnTestStart(string item);
        void markOnTestPass(string item);
        void markOnTestFailed(string item);
        void markOnTestfinish(string item);
    }
}
