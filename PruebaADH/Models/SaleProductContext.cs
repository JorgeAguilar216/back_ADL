using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaADH.Models;

namespace PruebaADH.Models
{
    public class SaleProductContext:DbContext
    {
        public SaleProductContext(DbContextOptions<SaleProductContext>options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<PruebaADH.Models.Sales> Sales { get; set; }

    }
}
