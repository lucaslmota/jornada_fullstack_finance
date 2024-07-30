using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Core.Requests.Transactions
{
    public class DeleteTransactionRequest : RequestBase
    {
        public long Id { get; set; }
    }
}