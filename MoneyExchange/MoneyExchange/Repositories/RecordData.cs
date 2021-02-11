using Microsoft.EntityFrameworkCore;
using MoneyExchange.DTO;
using MoneyExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.Repositories
{
    public class RecordData:IRecordData
    {
        private readonly ApplicationDBContext _dbContext;

        public RecordData()
        {
        }

        public RecordData(ApplicationDBContext dbContex)
        {
            _dbContext = dbContex;
        }
       
        public IEnumerable<History> GetHistory() 
        {

            var history = _dbContext.History.ToList();
            return history;
        }
    }
}
