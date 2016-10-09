using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearBot.Core.ViewModel;

namespace BearBot.Infrastructure.Service.Interface
{
    public interface IDashboardService
    {
        DashboardViewModel createViewModel();
    }
}
