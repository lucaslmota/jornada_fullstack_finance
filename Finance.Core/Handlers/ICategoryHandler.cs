using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finance.Core.Models;
using Finance.Core.Requests.Categories;
using Finance.Core.Responses;

namespace Finance.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<ResponseBase<Category?>> CreatAsync(CreateCategoryRequest request);
        Task<ResponseBase<Category?>> UpdateAsync(UpdateCategoryRequest request);
        Task<ResponseBase<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<ResponseBase<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
        Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoryRequest request);
    }
}