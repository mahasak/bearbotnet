using BearBot.Infrastructure.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearBot.Core.Model;
using BearBot.Core.Enumeration;

namespace BearBot.Infrastructure.Repository
{
    public class ScenarioRepository : IScenarioRepository
    {
        public List<Scenario> Fetch()
        {
            var scenario = new List<Scenario>();

            scenario.Add(new Scenario(1, "Test Main Page", "", 0.1, ScenarioLastRunStatus.SUCCESS));
            scenario.Add(new Scenario(2, "Test Login Feature", "", 0.1, ScenarioLastRunStatus.SUCCESS));
            scenario.Add(new Scenario(3, "Test Logout Feature", "", 0.1, ScenarioLastRunStatus.SUCCESS));
            scenario.Add(new Scenario(4, "Scenario 4", "", 0.1, ScenarioLastRunStatus.FAIL));
            scenario.Add(new Scenario(5, "Scenario 5", "", 0.1, ScenarioLastRunStatus.SUCCESS));

            scenario.Add(new Scenario(6, "Scenario 6", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            scenario.Add(new Scenario(7, "Scenario 7", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            scenario.Add(new Scenario(8, "Scenario 8", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            scenario.Add(new Scenario(9, "Scenario 9", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            scenario.Add(new Scenario(10, "Scenario 10", "", 0.1, ScenarioLastRunStatus.NOTRUN));

            scenario.Add(new Scenario(11, "Scenario 11", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            scenario.Add(new Scenario(12, "Scenario 12", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            scenario.Add(new Scenario(13, "Scenario 13", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            scenario.Add(new Scenario(14, "Scenario 14", "", 0.1, ScenarioLastRunStatus.NOTRUN));
            //scenario.Add(new Scenario(15, "Scenario 15", "", 0.1, ScenarioLastRunStatus.NOTRUN));

            return scenario;
        }
    }
}
