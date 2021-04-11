using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VerduleriaApp.Data.Models
{
    public class Sale
    { 
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Total { get; set; }

        public virtual ICollection<Concept> Concepts { get; set; }
    }
}
