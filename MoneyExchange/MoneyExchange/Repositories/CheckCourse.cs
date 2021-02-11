using MoneyExchange.DTO;
using MoneyExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.Repositories
{
    public class CheckCourse:ICheckCourse
    {
       
        public decimal Check(MoneyExchangeViewModel model)
        {
            if (model.ExchangeHistory.ToAmount == 0)
            {
                var result = (model.ExchangeHistory.FromAmount * Convert.ToDecimal(model.ExchangeHistory.ToCurrency)) / Convert.ToDecimal(model.ExchangeHistory.FromCurrency);

                return result;
            }
            if (model.ExchangeHistory.FromAmount == 0)
            {
                var result = (model.ExchangeHistory.ToAmount * Convert.ToDecimal(model.ExchangeHistory.FromCurrency)) / Convert.ToDecimal(model.ExchangeHistory.ToCurrency);

                return result;
            }
            else 
            {
                var result = -1;
                return result;
            }
        }
    }
}
