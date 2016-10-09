using BearBot.Infrastructure.Bot.Metrics;
using BearBot.Infrastructure.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BearBot.Web.Controllers
{
    public class DashboardController : Controller
    {
        IBearBotMetric bearbotMetric;
        IDashboardService dashboardService;

        public DashboardController(IBearBotMetric bearbotMetric, IDashboardService dashboardService)
        {
            this.bearbotMetric = bearbotMetric;
            this.dashboardService = dashboardService;
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            var dashboardViewMode = dashboardService.createViewModel();

            return View(dashboardViewMode);
        }
    }
}