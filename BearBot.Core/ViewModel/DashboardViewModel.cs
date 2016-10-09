using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Core.ViewModel
{
    public class DashboardViewModel
    {
        public int TotalScenarios { get; set; }
        public int CurrentScenario { get; set; }
        public double RunTime { get; set; }
        public IEnumerable<IEnumerable<ScenarioViewModel>> ScenariosNodes { get; set; }

        public DashboardViewModel()
        {
            this.TotalScenarios = 0;
            this.CurrentScenario = 0;
            this.RunTime = 0;
        }
    }
}
