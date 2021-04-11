using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VerduleriaApp.Data.Requests
{
    public class SaleRequest
    { 
        [Required]
        public decimal Total { get; set; }

        [Required]
        [MinLength(1)]
        public List<ConceptRequest> Concepts { get; set; }

        public SaleRequest()
        {
            this.Concepts = new List<ConceptRequest>();
        }
    }

    public class ConceptRequest
    {
        public int Amount { get; set; }
        public int IdProduct { get; set; }

    }
}
