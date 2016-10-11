using BearBot.Infrastructure.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearBot.Core.Model;
using BearBot.Infrastructure.Repository.Interface;

namespace BearBot.Infrastructure.Service
{
    public class BearMasterService : IBearMasterService
    {
        private readonly IScenarioRepository scenarioRepository;

        public BearMasterService(
            IScenarioRepository scenarioRepository)
        {
            this.scenarioRepository = scenarioRepository;
        }

        public List<Scenario> GetScenario()
        {
            return scenarioRepository.Fetch();
        }
    }
}
