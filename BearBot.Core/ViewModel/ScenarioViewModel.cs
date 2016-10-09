using BearBot.Core.Enumeration;
using BearBot.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Core.ViewModel
{
    public class ScenarioViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Story { get; set; }
        public ScenarioLastRunStatus LastRunStatus { get; set; }
        public double LastRunTime { get; set; }
        public ScenarioViewModel(Scenario scenario)
        {
            this.Id = scenario.Id;
            this.Name = scenario.Name;
            this.Story = scenario.Story;
            this.LastRunTime = scenario.LastRunTime;
            this.LastRunStatus = scenario.LastRunStatus;
        }
    }
}
