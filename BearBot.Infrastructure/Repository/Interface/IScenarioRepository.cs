using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearBot.Core.ViewModel;
using BearBot.Core.Model;

namespace BearBot.Infrastructure.Repository.Interface
{
    public interface IScenarioRepository
    {
        List<Scenario> Fetch();
    }
}
