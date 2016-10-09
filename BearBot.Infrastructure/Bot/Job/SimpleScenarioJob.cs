using BearBot.Infrastructure.Bot.Control;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Infrastructure.Bot.Job
{
    public class SimpleScenarioJob : IJob
    {
        void IJob.Execute(IJobExecutionContext context)
        {
            //throw new NotImplementedException();
            JobKey key = context.JobDetail.Key;
            JobDataMap dataMap = context.JobDetail.JobDataMap;

            string scenarioName = (string)context.MergedJobDataMap.Get("scenarioName");
            string scenario = (string)context.MergedJobDataMap.Get("scenario");

            var bearSlave = new BearSlave();

            bearSlave.run(scenarioName, scenario);
        }

    }
}
