using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BestCompraWeb.Models
{
    public class BestCompraWebContext : DbContext
    {
        public BestCompraWebContext (DbContextOptions<BestCompraWebContext> options)
            : base(options)
        {
        }

        public DbSet<BestCompraWeb.Models.Produto> Produto { get; set; }
    }
}
