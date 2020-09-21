using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Pirce { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
