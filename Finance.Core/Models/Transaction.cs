using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finance.Core.Enums;

namespace Finance.Core.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? PaidOrReceivedAt { get; set; } = DateTime.Now;
        public ETransactionType Type { get; set; } = ETransactionType.Whithdraw;
        public decimal Amount { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public string UserId { get; set; } = string.Empty;



    }
}