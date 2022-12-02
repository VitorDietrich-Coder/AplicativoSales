using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales.Models;

namespace Sales.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext (DbContextOptions<SalesContext> options)
            : base(options)
        {
        }

        public DbSet<Departamentos> Departamento { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<RecordeVendas> RecordeVendas { get; set; }
    }
}
