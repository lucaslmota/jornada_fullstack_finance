using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Core.Requests
{
    public abstract class PagedRequest : RequestBase
    {
        public int PageSize { get; set; } = 25;

        public int PageNumber { get; set; } = 1;

    }
}