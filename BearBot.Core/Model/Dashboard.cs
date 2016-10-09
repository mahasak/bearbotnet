using BearBot.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Core.ViewModel
{
    public class Dashboard
    {
        public int TotalScenarios { get; set; }
        public int CurrentScenario { get; set; }
        public string RunTime { get; set; }
        public List<Scenario> Scenarios { get; set; }
    }
}
