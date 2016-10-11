using BearBot.Infrastructure.App_Start;
using BearBot.Infrastructure.Bot.Job;
using BearBot.Infrastructure.Bot.Metrics;
using BearBot.Infrastructure.Service.Interface;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Threading.Tasks;

namespace BearBot.Infrastructure.Bot.Control
{
    public class BearSlaveMaster
    {
        IBearMasterService bearMasterService;
        public BearSlaveMaster()
        {
            this.bearMasterService = UnityConfig.GetConfiguredContainer().Resolve<IBearMasterService>();
        }

        public void Roar(
            IBearBotMetric bearbotMetrics
            , int seconds
            )
        {

            ISchedulerFactory schedFactory = new StdSchedulerFactory();
            
            IScheduler scheduler = schedFactory.GetScheduler();
            scheduler.Start();

            this.bearMasterService.GetScenario().ForEach(scenario => {

                IJobDetail job = JobBuilder.Create<SimpleScenarioJob>()
                    .Build();

                ITrigger trigger = TriggerBuilder.Create()
                   .WithSimpleSchedule(x => x.WithIntervalInSeconds(seconds).RepeatForever())
                   .UsingJobData("scenarioName", scenario.Name)
                   .UsingJobData("scenario", @scenario.Story)
                   .Build();

                scheduler.ScheduleJob(job, trigger);
            });

            // Mock feature for test, We should get it from repository
            //var pass = @"
            //    Feature: GoToWebsite
            //    Scenario: GoToWebsite
            //        Given Go to website http://www.agoda.com
            //        Then Title should contain Agoda
            //        Then Title should be Agoda.com: Smarter Hotel Booking
            //        Then Home tab size should be 2
            //";

            //IJobDetail job = JobBuilder.Create<SimpleScenarioJob>()
            //    .Build();

            //ITrigger trigger = TriggerBuilder.Create()
            //       .WithSimpleSchedule(x => x.WithIntervalInSeconds(seconds).RepeatForever())
            //       .UsingJobData("scenarioName", "TestGoToWebSite")
            //       .UsingJobData("scenario", pass)
            //       .Build();
            
            //scheduler.ScheduleJob(job, trigger);
        }
    }
}
