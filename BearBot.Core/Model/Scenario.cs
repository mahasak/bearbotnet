using BearBot.Core.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Core.Model
{
    public class Scenario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Story { get; set; }
        public double LastRunTime { get; set; }
        public ScenarioLastRunStatus LastRunStatus { get; set; }


        public Scenario(int id, string name, string story, double runtime, ScenarioLastRunStatus lastRunStatus = ScenarioLastRunStatus.NOTRUN)
        {
            this.Id = id;
            this.Name = name;
            this.Story = story;
            this.LastRunTime = runtime;
            this.LastRunStatus = lastRunStatus;
        }
    }
}
