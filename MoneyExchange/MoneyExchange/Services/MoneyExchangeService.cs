using MoneyExchange.DTO;
using MoneyExchange.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MoneyExchange.Services
{
    public class MoneyExchangeService : IMoneyExchangeService
    {
        private readonly ApplicationDBContext _dbContext;

       

        public MoneyExchangeService(ApplicationDBContext dbContex)
        {
            _dbContext = dbContex;
        }
        private readonly string url = "https://api.exchangeratesapi.io/latest";
        public MoneyExchangeService()
        {
        }
        public async Task<Rates> APIResult()
            {
                
                WebRequest webRequest = WebRequest.Create(url);
                WebResponse webResponse = await webRequest.GetResponseAsync();

                using (Stream stream = webResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    string responceFromServer = await reader.ReadToEndAsync();
                //var list= JsonConvert.DeserializeObject<Hashtable>(responceFromServer);
                //List<string> list2 = new List<string> { };
                ////list2.Add(Convert.ToString(list["rates"]));
                //var result = JsonConvert.DeserializeObject<Dictionary<string,decimal>>(Convert.ToString(list["rates"]));
                   
                    string basekey = "EUR";
                    decimal basevalue = 1;
                    
                    
                    var result = JsonConvert.DeserializeObject<Rates>(responceFromServer);
                    result.Money.Add(basekey, basevalue);

                //Rates rates =  rates.Currency=result.Keys

                return result;
                }
            }
        public bool HistoryRecord(MoneyExchangeViewModel model)
        {
            
            string key = "";
            foreach (var item in model.Money.Money)
            {
                if (item.Value == Convert.ToDecimal(model.ExchangeHistory.FromCurrency))
                {
                    key = item.Key;

                }
            }
            string key2 = "";
            foreach (var item in model.Money.Money)
            {
                if (item.Value == Convert.ToDecimal(model.ExchangeHistory.ToCurrency))
                {
                    key2 = item.Key;

                }
            }
            model.ExchangeHistory.Date = DateTime.Now;
            History record = new History
            {
                FromAmount = model.ExchangeHistory.FromAmount,
                FromCurrency = key,
                ToAmount = model.ExchangeHistory.ToAmount,
                ToCurrency = key2,
                Date = model.ExchangeHistory.Date,
            };

            _dbContext.History.Add(record);
            _dbContext.SaveChanges();
            return true;
        }


    }
}
