using MoneyExchange.DTO;
using MoneyExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.Repositories
{
    public interface IRecordData
    {
       
       IEnumerable<History> GetHistory(); 
    }
}
