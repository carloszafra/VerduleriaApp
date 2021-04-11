using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VerduleriaApp.Data.Models
{
    public class Concept
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Sale))]
        public int IdSale { get; set; }

        public int Amount { get; set; }

        [ForeignKey(nameof(Product))]
        public int IdProduct { get; set; }

        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
