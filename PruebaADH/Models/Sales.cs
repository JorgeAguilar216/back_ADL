using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaADH.Models
{
    public class Sales
    {
        [Key]
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        [Column(TypeName = "bigint")]
        public int Cantidad { get; set; }
        [Column(TypeName = "bigint")]
        public int ValorU { get; set; }
        [Column(TypeName = "bigint")]
        public int ValorT { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

    }
}
