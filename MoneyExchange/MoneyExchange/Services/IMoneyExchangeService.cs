using MoneyExchange.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.Services
{
    public interface IMoneyExchangeService
    {
        Task<Rates> APIResult();
        bool HistoryRecord(MoneyExchangeViewModel model);

    }
}
