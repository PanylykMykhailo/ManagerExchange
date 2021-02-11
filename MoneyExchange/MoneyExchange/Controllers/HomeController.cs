using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoneyExchange.DTO;
using MoneyExchange.Models;
using MoneyExchange.Repositories;
using MoneyExchange.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMoneyExchangeService _moneyExchangeService;
        private readonly ICheckCourse _checkCourse;
        private readonly IRecordData _recordData;
        

        public HomeController( IMoneyExchangeService moneyExchangeService, ICheckCourse checkCourse, IRecordData recordData)
        {
            _moneyExchangeService = moneyExchangeService;
            _checkCourse = checkCourse;
            _recordData = recordData;
        }

        public async Task<IActionResult> Index()
        {
            var money = await _moneyExchangeService.APIResult();
           
            var result = new MoneyExchangeViewModel { Money = money};
            result.Money.Count = 1;
            return View(result);
        }

        public IActionResult History()
        {
            var history =_recordData.GetHistory();
            return View(history);

        }
        [HttpPost]
        public async Task<IActionResult> CheckExchange(MoneyExchangeViewModel model)
        {
            
            var money = await _moneyExchangeService.APIResult();
            if (model.ExchangeHistory.FromAmount == 0)
            {
                var amount = _checkCourse.Check(model);
                model.ExchangeHistory.FromAmount = amount;
            }
            else 
            {
                var amount = _checkCourse.Check(model);
                model.ExchangeHistory.ToAmount = amount;
            }
           
            model.Money = money;

            var record = _moneyExchangeService.HistoryRecord(model);
            
            return PartialView("_Partial", model);
            
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
