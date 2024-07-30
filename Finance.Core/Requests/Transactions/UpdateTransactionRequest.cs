using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Finance.Core.Enums;

namespace Finance.Core.Requests.Transactions
{
    public class UpdateTransactionRequest : RequestBase
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Título inválido")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tipo inválido")]
        public ETransactionType Type { get; set; } = ETransactionType.Whithdraw;

        [Required(ErrorMessage = "Valor inválido")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Categoria inválido")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Data inválido")]
        public DateTime? PaidOrReceivedAt { get; set; } = DateTime.Now;

    }
}