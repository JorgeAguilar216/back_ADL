using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaADH.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "bigint")]
        public int ValueU { get; set; }
        public virtual IEnumerable<Sales> Sales { get; set; }

    }
}
