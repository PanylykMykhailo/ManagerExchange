using MoneyExchange.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExchange.Repositories
{
    public interface ICheckCourse
    {
        public decimal Check(MoneyExchangeViewModel model);
    }
}
