using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Core.Requests
{
    public abstract class RequestBase
    {
        public string UserId { get; set; } = string.Empty;
    }
}