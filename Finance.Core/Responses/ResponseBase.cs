using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Finance.Core.Responses
{
    public class ResponseBase<TData>
    {
        private int _code = Configuration.DefaultStatusCode;

        [JsonConstructor]
        public ResponseBase() => _code = Configuration.DefaultStatusCode;

        public ResponseBase(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;
        }

        public TData? Data { get; set; }

        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}