using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Core.Requests.Categories
{
    public class DeleteCategoryRequest : RequestBase
    {
        public long Id { get; set; }
    }
}