using BearBot.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearBot.Infrastructure.Service.Interface
{
    public interface IBearMasterService
    {
        List<Scenario> GetScenario();
    }
}
