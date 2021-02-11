using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.DTO
{
    public class Rates
    {
        [JsonProperty("rates")]
        public Dictionary<string,decimal> Money { get; set; }      
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public string Keys { get; set; }
        public decimal Value { get; set; }
    }
}
