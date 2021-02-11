using MoneyExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.DTO
{
    public class MoneyExchangeViewModel
    {
        public History ExchangeHistory { get; set; }
        public Rates Money { get; set; }
    }
}
