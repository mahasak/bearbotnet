using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearBot.Core.ViewModel;
using BearBot.Infrastructure.Service.Interface;
using BearBot.Infrastructure.Repository.Interface;
using BearBot.Core.Enumeration;
using BearBot.Infrastructure.Extension;

namespace BearBot.Infrastructure.Service
{
    public class DashboardService : IDashboardService
    {
        IScenarioRepository scenarioRepository;

        public DashboardService(IScenarioRepository scenarioRepository)
        {
            this.scenarioRepository = scenarioRepository;
        }

        public DashboardViewModel createViewModel()
        {
            var dashboard = new DashboardViewModel();
            var scenarios = new List<ScenarioViewModel>();

            scenarioRepository
                .Fetch()
                .ForEach(scenario => scenarios.Add(new ScenarioViewModel(scenario)));
            
            scenarios.ForEach(scenario =>
            {
                dashboard.TotalScenarios += 1;
                dashboard.RunTime += scenario.LastRunTime;
                if (scenario.LastRunStatus != ScenarioLastRunStatus.NOTRUN)
                    dashboard.CurrentScenario += 1;
            });

            dashboard.ScenariosNodes = LinqExtensions.SplitGroup(scenarios,5);
            
            return dashboard;
        }
    }

    
}
