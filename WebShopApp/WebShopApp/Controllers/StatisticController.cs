using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using WebShopApp.Core.Contracts;
using WebShopApp.Models.Statistic;

namespace WebShopApp.Controllers
{
    public class StatisticController:Controller
    {
        private readonly IStatisticService statisticsService;
        public StatisticController(IStatisticService statisticService)
        {
            this.statisticsService = statisticService;
        }
        public IActionResult Index()
        {
            StatisticVM statistics = new StatisticVM();

            statistics.CountClients = statisticsService.CountClients();
            statistics.CountProducts = statisticsService.CountProducts();
            statistics.CountOrders = statisticsService.CountOrders();
            statistics.SumOrders = (int)statisticsService.SumOrders();

            return View(statistics);
        }
    }
}
