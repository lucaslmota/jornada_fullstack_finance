using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finance.Core.Models;
using Finance.Core.Requests.Transactions;
using Finance.Core.Responses;

namespace Finance.Core.Handlers
{
    public interface ITransactionHandler
    {
        Task<ResponseBase<Transaction?>> CreatAsync(CreateTransactionRequest request);
        Task<ResponseBase<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
        Task<ResponseBase<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
        Task<ResponseBase<Transaction?>> GetByIdAsync(GegTransactionByIdRequest request);
        Task<PagedResponse<List<Category>?>> GetAllAsync(GetTransactionsByPeriodRequest request);
    }
}