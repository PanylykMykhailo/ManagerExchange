using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.Models
{
    public class History
    {
        public int Id { get; set; }
        public string FromCurrency { get; set; }
        public decimal FromAmount  { get; set; }
        public string ToCurrency { get; set; }
        public decimal ToAmount { get; set; }
        public DateTime Date { get; set; }

    }
}
