using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Core.Requests.Categories
{
    public class CreateCategoryRequest : RequestBase
    {
        [Required(ErrorMessage = "Título inválido")]
        [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

    }
}