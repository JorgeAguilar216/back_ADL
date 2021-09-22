using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaADH.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Column(TypeName = "bigint")]
        public long Cedula { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [Column(TypeName = "bigint")]
        public long Phone { get; set; }
        public virtual IEnumerable<Sales> Sales { get; set; }
    }
}
